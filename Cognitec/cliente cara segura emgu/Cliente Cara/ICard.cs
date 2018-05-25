using System;

namespace ClienteCara
{
	/// <summary>
	/// Interfaz que ofrece el acceso basico a las funciones de las tarjetas, debe ser
    /// implementada por una clase.
    /// </summary>
	public interface	ICard
	{
        /// <summary>
        /// Simula la funcion PC/SC SCardListReaders
        /// 
        /// LONG SCardListReaders(SCARDCONTEXT hContext, 
        ///		LPCTSTR mszGroups, 
        ///		LPTSTR mszReaders, 
        ///		LPDWORD pcchReaders 
        ///	);
        /// </summary>
        /// <returns>Un array de Strings con el nombre de las lectoras disponibles</returns>
		string[]	ListReaders();

        /// <summary>
        /// Metodo para conectarse con la lectora.
        /// Simula la funcion PC/SC
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
		void	Connect(string Reader, SHARE ShareMode, PROTOCOL PreferredProtocols);

        /// <summary>
        /// Simula la funcion PC/SC
        ///	LONG SCardDisconnect(
        ///		IN SCARDHANDLE hCard,
        ///		IN DWORD dwDisposition
        ///	);
        /// </summary>
        /// <param name="Disposition"></param>
		void	Disconnect(DISCONNECT Disposition);

        /// <summary>
        /// Simula la funcion PC/SC
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
        RespuestaTarjeta Transmit(ComandoTarjeta comando);

        /// <summary>
        /// Simula la funcion PC/SC
        /// LONG SCardBeginTransaction(
        ///     SCARDHANDLE hCard
        //  );
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Sobreescribe la funcion PC/SC
        /// LONG SCardEndTransaction(
        ///     SCARDHANDLE hCard,
        ///     DWORD dwDisposition
        /// );
        /// </summary>
        /// <param name="Disposition">Un valor de la enumeración de DISCONNECT</param>
        void EndTransaction(DISCONNECT Disposition);

        /// <summary>
        /// Obtiene las caracteristicas de la tarjeta.
        /// </summary>
        /// <param name="AttribId">Identificador del atributo a obtener</param>
        /// <returns>Contenido del atributo deseado</returns>
        byte[] GetAttribute(UInt32 AttribId);
	}

	/// <summary>
	/// SCOPE
	/// </summary>
	public enum SCOPE
	{
		/// <summary>
		/// The context is a user context, and any database operations are performed within the
		/// domain of the user.
		/// </summary>
		User,		

		/// <summary>
		/// The context is that of the current terminal, and any database operations are performed
		/// within the domain of that terminal.  (The calling application must have appropriate
		/// access permissions for any database actions.)
		/// </summary>
		Terminal,	

		/// <summary>
		/// The context is the system context, and any database operations are performed within the
		/// domain of the system.  (The calling application must have appropriate access
		/// permissions for any database actions.)
		/// </summary>
		System	
	}

	/// <summary>
	/// SHARE
	/// </summary>
	public	enum SHARE
	{
		/// <summary>
		/// No compartirá la tarjeta con otras aplicaciones
		/// </summary>
		Exclusive = 1,	

		/// <summary>
		/// Comparte la tarjeta con otras aplicaciones
		/// </summary>
		Shared,			

		/// <summary>
        /// Esta aplicación requiere el control directo de la lectora, por lo que no estara disponible para otras aplicaciones.
		/// </summary>
		Direct			
	}


	/// <summary>
	/// PROTOCOL
	/// </summary>
	public	enum	PROTOCOL
	{
		/// <summary>
		/// No hay protocolo activo.
		/// </summary>
		Undefined	= 0x00000000,	

		/// <summary>
		/// T=0 es el protocolo activo
		/// </summary>
		T0			= 0x00000001,	

		/// <summary>
        /// T=1 es el protocolo activo
		/// </summary>
		T1			= 0x00000002,	

		/// <summary>
        /// Raw es el protocolo activo
		/// </summary>
		Raw			= 0x00010000, 
		Default		= unchecked ((int) 0x80000000),  // Use implicit PTS.

		/// <summary>
        /// T=1 or T=0 pueden ser el protocolo activo
		/// </summary>
		T0orT1		= T0 | T1
	}


	/// <summary>
	/// DISCONNECT
	/// </summary>
	public	enum	DISCONNECT
	{
		/// <summary>
		/// No hacer nada
		/// </summary>
		Leave,		

		/// <summary>
		/// Resetear la tarjeta a la salida
		/// </summary>
		Reset,		

		/// <summary>
		/// Apagar la tarjeta
		/// </summary>
		Unpower,	

		/// <summary>
		/// Extraccion de la tarjeta.
		/// </summary>
		Eject	
	}
}
