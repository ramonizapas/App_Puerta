using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ClienteCara
{
    /// <summary>
    /// CARD_STATE, usada para la función SCardGetStatusChanged PC/SC 
    /// </summary>
    enum CARD_STATE
    {
        UNAWARE = 0x00000000,
        IGNORE = 0x00000001,
        CHANGED = 0x00000002,
        UNKNOWN = 0x00000004,
        UNAVAILABLE = 0x00000008,
        EMPTY = 0x00000010,
        PRESENT = 0x00000020,
        ATRMATCH = 0x00000040,
        EXCLUSIVE = 0x00000080,
        INUSE = 0x00000100,
        MUTE = 0x00000200,
        UNPOWERED = 0x00000400
    }

	/// <summary>
	/// SCARD_IO_STRUCTURE
    ///  
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct	SCard_IO_Request
	{
		public UInt32	m_dwProtocol;
		public UInt32	m_cbPciLength;
	}


    /// <summary>
    /// Estructura SCARD_READERSTATE de PC/SC
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SCard_ReaderState
    {
        public string m_szReader;
        public IntPtr m_pvUserData;
        public UInt32 m_dwCurrentState;
        public UInt32 m_dwEventState;
        public UInt32 m_cbAtr;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
        public byte[] m_rgbAtr;
    }

	/// <summary>
	/// Implementacion de ICard usando (P/Invoke) de PC/SC
	/// </summary>
	public class CardNative : CardBase
	{
		private	UInt32	m_hContext = 0;
		private	UInt32	m_hCard = 0;
		private	UInt32	m_nProtocol = (uint) PROTOCOL.T0;
		private	int	m_nLastError = 0;

		#region FUNCIONES_PCSC_IMPORTADAS_DE_WINSCARD.DLL
        /// <summary>
        /// SCardGetStatusChanged winscard.dll
        /// </summary>
        /// <param name="hContext"></param>
        /// <param name="dwTimeout"></param>
        /// <param name="rgReaderStates"></param>
        /// <param name="cReaders"></param>
        /// <returns></returns>
        [DllImport("winscard.dll", SetLastError = true)]
        internal static extern int SCardGetStatusChange(UInt32 hContext,
            UInt32 dwTimeout,
            [In,Out] SCard_ReaderState[] rgReaderStates,
            UInt32 cReaders);

		/// <summary>
		/// SCardListReaders winscard.dll
		/// </summary>
		/// <param name="hContext"></param>
		/// <param name="mszGroups"></param>
		/// <param name="mszReaders"></param>
		/// <param name="pcchReaders"></param>
		/// <returns></returns>
		[DllImport("winscard.dll", SetLastError=true)]
		internal static extern int SCardListReaders(UInt32 hContext,
			[MarshalAs(UnmanagedType.LPTStr)] string mszGroups,
			IntPtr mszReaders,
			out UInt32	pcchReaders);

		/// <summary>
		/// SCardEstablishContext winscard.dll
		/// </summary>
		/// <param name="dwScope"></param>
		/// <param name="pvReserved1"></param>
		/// <param name="pvReserved2"></param>
		/// <param name="phContext"></param>
		/// <returns></returns>
		[DllImport("winscard.dll", SetLastError=true)]
		internal	static	extern	int	SCardEstablishContext(UInt32 dwScope,
			IntPtr pvReserved1,
			IntPtr pvReserved2,
			IntPtr phContext);

		/// <summary>
		/// SCardReleaseContext winscard.dll
		/// </summary>
		/// <param name="hContext"></param>
		/// <returns></returns>
		[DllImport("winscard.dll", SetLastError=true)]
		internal static extern	int	SCardReleaseContext(UInt32 hContext);

		/// <summary>
		/// SCardConnect winscard.dll
		/// </summary>
		/// <param name="hContext"></param>
		/// <param name="szReader"></param>
		/// <param name="dwShareMode"></param>
		/// <param name="dwPreferredProtocols"></param>
		/// <param name="phCard"></param>
		/// <param name="pdwActiveProtocol"></param>
		/// <returns></returns>
		[DllImport("winscard.dll", SetLastError=true, CharSet=CharSet.Auto)]
		internal static	extern	int	SCardConnect(UInt32 hContext,
			[MarshalAs(UnmanagedType.LPTStr)] string szReader,
			UInt32	dwShareMode, 
			UInt32	dwPreferredProtocols,
			IntPtr	phCard, 
			IntPtr	pdwActiveProtocol);

		/// <summary>
		/// SCardDisconnect winscard.dll
		/// </summary>
		/// <param name="hCard"></param>
		/// <param name="dwDisposition"></param>
		/// <returns></returns>
		[DllImport("winscard.dll", SetLastError=true)]
		internal static extern	int	SCardDisconnect(UInt32 hCard,
			UInt32 dwDisposition);

		/// <summary>
		/// SCardTransmit winscard.dll
		/// </summary>
		/// <param name="hCard"></param>
		/// <param name="pioSendPci"></param>
		/// <param name="pbSendBuffer"></param>
		/// <param name="cbSendLength"></param>
		/// <param name="pioRecvPci"></param>
		/// <param name="pbRecvBuffer"></param>
		/// <param name="pcbRecvLength"></param>
		/// <returns></returns>
		[DllImport("winscard.dll", SetLastError=true)]
		internal static extern	int	SCardTransmit(UInt32 hCard,
			[In] ref SCard_IO_Request pioSendPci,
			byte[] pbSendBuffer,
			UInt32 cbSendLength,
			IntPtr pioRecvPci,
			[Out] byte[] pbRecvBuffer,
			out UInt32 pcbRecvLength
			);

        /// <summary>
        /// SCardBeginTransaction winscard.dll
        /// </summary>
        /// <param name="hContext"></param>
        /// <returns></returns>
        [DllImport("winscard.dll", SetLastError = true)]
        internal static extern int SCardBeginTransaction(UInt32 hContext);

        /// <summary>
        /// SCardEndTransaction winscard.dll
        /// </summary>
        /// <param name="hContext"></param>
        /// <returns></returns>
        [DllImport("winscard.dll", SetLastError = true)]
        internal static extern int SCardEndTransaction(UInt32 hContext, UInt32 dwDisposition);

        [DllImport("winscard.dll", SetLastError = true)]
        internal static extern int SCardGetAttrib(UInt32 hCard,
            UInt32 dwAttribId,
            [Out] byte[] pbAttr,
            out UInt32 pcbAttrLen);

        #endregion WINSCARD_FUNCTIONS

		/// <summary>
		/// Constructor
		/// </summary>
		public CardNative()
		{
		}

		/// <summary>
		/// Eliminación del Objeto
		/// </summary>
		~CardNative()
		{
			Disconnect(DISCONNECT.Unpower);

			ReleaseContext();
		}

		#region Métodos implementados de la interfaz ICARD

		/// <summary>
		/// Sobreescribe la funcion PC/SC SCardListReaders
        /// 
		/// LONG SCardListReaders(SCARDCONTEXT hContext, 
		///		LPCTSTR mszGroups, 
		///		LPTSTR mszReaders, 
		///		LPDWORD pcchReaders 
		///	);
		/// </summary>
		/// <returns>Un Array de Strings con el nombre de las lectoras disponibles</returns>
		public	override string[]	ListReaders()
		{
			EstablishContext(SCOPE.User);

			string[]	sListReaders = null;
			UInt32	pchReaders = 0;
			IntPtr	szListReaders = IntPtr.Zero;

			m_nLastError = SCardListReaders(m_hContext, null, szListReaders, out pchReaders);
			if (m_nLastError == 0)
			{
				szListReaders = Marshal.AllocHGlobal((int) pchReaders);
				m_nLastError = SCardListReaders(m_hContext, null, szListReaders, out pchReaders);
				if (m_nLastError == 0)
				{
					char[] caReadersData = new char[pchReaders];
					int	nbReaders = 0;
					for (int nI = 0; nI < pchReaders; nI++)
					{
						caReadersData[nI] = (char) Marshal.ReadByte(szListReaders, nI);

						if (caReadersData[nI] == 0)
							nbReaders++;
					}

					// Remove last 0
					--nbReaders;

					if (nbReaders != 0)
					{
						sListReaders = new string[nbReaders];
						char[] caReader = new char[pchReaders];
						int	nIdx = 0;
						int	nIdy = 0;
						int	nIdz = 0;
						// Get the nJ string from the multi-string

						while(nIdx < pchReaders - 1)
						{
							caReader[nIdy] = caReadersData[nIdx];
							if (caReader[nIdy] == 0)
							{
								sListReaders[nIdz] = new string(caReader, 0, nIdy);
								++nIdz;
								nIdy = 0;
								caReader = new char[pchReaders];
							}
							else
								++nIdy;

							++nIdx;
						}
					}

				}

				Marshal.FreeHGlobal(szListReaders);
			}

			ReleaseContext();

			return sListReaders;
		}

		/// <summary>
        /// Sobreescribe la funcion PC/SC SCardEstablishContext
		/// LONG SCardEstablishContext(
		///		IN DWORD dwScope,
		///		IN LPCVOID pvReserved1,
		///		IN LPCVOID pvReserved2,
		///		OUT LPSCARDCONTEXT phContext
		///	);
		/// </summary>
		/// <param name="Scope"></param>
		public void EstablishContext(SCOPE Scope)
		{
			IntPtr	hContext = Marshal.AllocHGlobal(Marshal.SizeOf(m_hContext));

			m_nLastError = SCardEstablishContext((uint) Scope, IntPtr.Zero, IntPtr.Zero, hContext);
			if (m_nLastError != 0)
			{
				string msg = "SCardEstablishContext error: " + m_nLastError;

				Marshal.FreeHGlobal(hContext);
				throw new Exception(msg);
			}

			m_hContext = (uint) Marshal.ReadInt32(hContext);

			Marshal.FreeHGlobal(hContext);
		}


		/// <summary>
        /// Sobreescribe la funcion PC/SC
		/// LONG SCardReleaseContext(
		///		IN SCARDCONTEXT hContext
		///	);
		/// </summary>
		public void ReleaseContext()
		{
			if (m_hContext != 0)
			{
				m_nLastError = SCardReleaseContext(m_hContext);

				if (m_nLastError != 0)
				{
					string	msg = "SCardReleaseContext error: " + m_nLastError;
					throw new Exception(msg);
				}

				m_hContext = 0;
			}
		}

		/// <summary>
        /// Metodo para conectarse con la lectora.
        /// Sobreescribe la funcion PC/SC
		///  LONG SCardConnect(
		///		IN SCARDCONTEXT hContext,
		///		IN LPCTSTR szReader,
		///		IN DWORD dwShareMode,
		///		IN DWORD dwPreferredProtocols,
		///		OUT LPSCARDHANDLE phCard,
		///		OUT LPDWORD pdwActiveProtocol
		///	);
		/// </summary>
		/// <param name="Reader">Lectora a utilizar</param>
		/// <param name="ShareMode"></param>
		/// <param name="PreferredProtocols"></param>
		public override void Connect(string Reader, SHARE ShareMode, PROTOCOL PreferredProtocols)
		{
			EstablishContext(SCOPE.User);

			IntPtr	hCard = Marshal.AllocHGlobal(Marshal.SizeOf(m_hCard));
			IntPtr	pProtocol = Marshal.AllocHGlobal(Marshal.SizeOf(m_nProtocol));

			m_nLastError = SCardConnect(m_hContext, 
				Reader, 
				(uint) ShareMode, 
				(uint) PreferredProtocols, 
				hCard,
				pProtocol);

            //if (m_nLastError != 0)
            //{
            //    string msg = "SCardConnect error: " + m_nLastError;

            //    Marshal.FreeHGlobal(hCard);
            //    Marshal.FreeHGlobal(pProtocol);
            //    throw new Exception(msg);
            //}

			m_hCard = (uint) Marshal.ReadInt32(hCard);
			m_nProtocol = (uint) Marshal.ReadInt32(pProtocol);

			Marshal.FreeHGlobal(hCard);
			Marshal.FreeHGlobal(pProtocol);
		}

		/// <summary>
        /// Sobreescribe la funcion PC/SC
		///	LONG SCardDisconnect(
		///		IN SCARDHANDLE hCard,
		///		IN DWORD dwDisposition
		///	);
		/// </summary>
		/// <param name="Disposition"></param>
		public override void Disconnect(DISCONNECT Disposition)
		{
			if (m_hCard != 0)
			{
				m_nLastError = SCardDisconnect(m_hCard, (uint) Disposition);
				m_hCard = 0;

				if (m_nLastError != 0)
				{
					string msg = "SCardDisconnect error: " + m_nLastError;
					throw new Exception(msg);
				}

				ReleaseContext();
			}
		}

        
		/// <summary>
        /// Sobreescribe la funcion PC/SC
		/// LONG SCardTransmit(
		///		SCARDHANDLE hCard,
		///		LPCSCARD_I0_REQUEST pioSendPci,
		///		LPCBYTE pbSendBuffer,
		///		DWORD cbSendLength,
		///		LPSCARD_IO_REQUEST pioRecvPci,
		///		LPBYTE pbRecvBuffer,
		///		LPDWORD pcbRecvLength
		///	);
		/// </summary>
		/// <param name="ApduCmd">ComandoTarjeta a enviar a la tarjeta</param>
		/// <returns>Un objeto RespuestaTarjeta con la respuesta de la tarjeta</returns>
		public override RespuestaTarjeta Transmit(ComandoTarjeta comando)
		{
			uint	longitudrespuesta = (uint) (comando.Length + RespuestaTarjeta.SW_LENGTH);
			byte[]	Buffer = null;
			byte[]	Respuesta = new byte[comando.Length + RespuestaTarjeta.SW_LENGTH];
			SCard_IO_Request	ioRequest = new SCard_IO_Request();
			ioRequest.m_dwProtocol = m_nProtocol;
			ioRequest.m_cbPciLength = 8;

			// Construccion del comando
			if (comando.Data == null)
			{
				Buffer = new byte[ComandoTarjeta.LONG_MINIMA + ((comando.Length != 0) ? 1 : 0)];

				if (comando.Length != 0)
					Buffer[4] = (byte) comando.Length;
			}
			else
			{
				Buffer = new byte[ComandoTarjeta.LONG_MINIMA + 1 + comando.Data.Length];

				for (int i = 0; i < comando.Data.Length; i++)
					Buffer[ComandoTarjeta.LONG_MINIMA + 1 + i] = comando.Data[i];

				Buffer[ComandoTarjeta.LONG_MINIMA] = (byte) comando.Data.Length;
			}
            //Se acaba de construir y se envia.
			Buffer[0] = comando.Class;
			Buffer[1] = comando.Ins;
			Buffer[2] = comando.P1;
			Buffer[3] = comando.P2;

			m_nLastError = SCardTransmit(m_hCard, ref ioRequest, Buffer, (uint) Buffer.Length, IntPtr.Zero, Respuesta, out longitudrespuesta); 
			if (m_nLastError != 0)
			{
				string msg = "Error: " + m_nLastError;
				throw new Exception(msg);
			}
			
			byte[] datosRespuesta = new byte[longitudrespuesta];

			for (int i = 0; i < longitudrespuesta; i++)
				datosRespuesta[i] = Respuesta[i];

			return new RespuestaTarjeta(datosRespuesta);
		}
        

        /// <summary>
        /// Sobreescribe la funcion PC/SC
        /// LONG SCardBeginTransaction(
        ///     SCARDHANDLE hCard
        //  );
        /// </summary>
        public override void BeginTransaction()
        {
            if (m_hCard != 0)
            {
                m_nLastError = SCardBeginTransaction(m_hCard);
                if (m_nLastError != 0)
                {
                    string msg = "SCardBeginTransaction error: " + m_nLastError;
                    throw new Exception(msg);
                }
            }
        }

        /// <summary>
        /// Sobreescribe la funcion PC/SC
        /// LONG SCardEndTransaction(
        ///     SCARDHANDLE hCard,
        ///     DWORD dwDisposition
        /// );
        /// </summary>
        /// <param name="Disposition">Un valor de la enumeración de DISCONNECT</param>
        public override void EndTransaction(DISCONNECT Disposition)
        {
            if (m_hCard != 0)
            {
                m_nLastError = SCardEndTransaction(m_hCard, (UInt32)Disposition);
                if (m_nLastError != 0)
                {
                    string msg = "SCardEndTransaction error: " + m_nLastError;
                    throw new Exception(msg);
                }
            }
        }

        /// <summary>
        /// Obtiene las caracteristicas de la tarjeta.
        /// </summary>
        /// <param name="AttribId">Identificador del atributo a obtener</param>
        /// <returns>Attribute content</returns>
        public override byte[] GetAttribute(UInt32 AttribId)
        {
            byte[] atributo = null;
            UInt32 attrLen = 0;

            m_nLastError = SCardGetAttrib(m_hCard, AttribId, atributo, out attrLen);
            if (m_nLastError == 0)
            {
                if (attrLen != 0)
                {
                    atributo = new byte[attrLen];
                    m_nLastError = SCardGetAttrib(m_hCard, AttribId, atributo, out attrLen);
                    if (m_nLastError != 0)
                    {
                        string msg = "SCardGetAttr error: " + m_nLastError;
                        throw new Exception(msg);
                    }
                }
            }
            else
            {
                string msg = "SCardGetAttr error: " + m_nLastError;
                throw new Exception(msg);
            }

            return atributo;
        }
        

        /// <summary>
        /// Esta funcion debe implementar el mecanismo de detección de la tarjeta.
        /// Cuando la tarjeta es insertada se llama al metodo CardInserted()
        /// Cuando la tarjeta es extraida se llama al metodo CardRemoved()
        /// 
        /// <param name="Reader">Nombre del objeto para monotorizar</param>
        /// </summary>
        protected override void RunCardDetection(object Reader)
        {
            bool bFirstLoop = true;
            UInt32 hContext = 0;    // Local context
            IntPtr phContext;

            phContext = Marshal.AllocHGlobal(Marshal.SizeOf(hContext));

            if (SCardEstablishContext((uint) SCOPE.User, IntPtr.Zero, IntPtr.Zero, phContext) == 0)
            {
                hContext = (uint)Marshal.ReadInt32(phContext);
                Marshal.FreeHGlobal(phContext);

                UInt32 nbReaders = 1;
                SCard_ReaderState[] readerState = new SCard_ReaderState[nbReaders];

                readerState[0].m_dwCurrentState = (UInt32) CARD_STATE.UNAWARE;
                readerState[0].m_szReader = (string)Reader;

                UInt32 eventState;
                UInt32 currentState = readerState[0].m_dwCurrentState;

                // Bucle de deteccion
                do
                {
                    if (SCardGetStatusChange(hContext, WAIT_TIME
                        , readerState, nbReaders) == 0)
                    {
                        eventState = readerState[0].m_dwEventState;
                        currentState = readerState[0].m_dwCurrentState;

                        // Comprobación del estado
                        if (((eventState & (uint) CARD_STATE.CHANGED) == (uint) CARD_STATE.CHANGED) && !bFirstLoop)    
                        {
                            // Estado cambiado
                            if ((eventState & (uint) CARD_STATE.EMPTY) == (uint) CARD_STATE.EMPTY)
                            {
                                // No hay tarjeta, tarjeta extraida
                                // -> Evento CardRemoved
                                CardRemoved();
                            }

                            if (((eventState & (uint)CARD_STATE.PRESENT) == (uint)CARD_STATE.PRESENT) && 
                                ((eventState & (uint) CARD_STATE.PRESENT) != (currentState & (uint) CARD_STATE.PRESENT)))
                            {
                                // Hay Tarjeta
                                // -> Evento CardInserted
                                CardInserted();
                            }

                            if ((eventState & (uint) CARD_STATE.ATRMATCH) == (uint) CARD_STATE.ATRMATCH)
                            {
                                // Hay una tarjeta introducida y coindice con el ATR esperado
                                CardInserted();
                            }
                        }

                        // Actualización del estado
                        readerState[0].m_dwCurrentState = eventState;

                        bFirstLoop = false;
                    }

                    Thread.Sleep(100);

                    if (m_bRunCardDetection == false)
                        break;
                }
                while (true);    // Exit on request
            }
            else
            {
                Marshal.FreeHGlobal(phContext);
                throw new Exception("PC/SC error");
            }

            SCardReleaseContext(hContext);
        }
        
        #endregion
	}
}
