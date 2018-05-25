using System;
using System.Text;

namespace ClienteCara
{
	/// <summary>
	/// Clase que representa el envio de un comando a la tarjeta
	/// </summary>
	public	class	ComandoTarjeta
	{
		/// <summary>
		/// Tamaño minimo de la trama a enviar a la tarjeta.
		/// </summary>
		public	const int	LONG_MINIMA = 4;

		private	byte	byteCla;
		private	byte	byteIns;
		private	byte	byteP1;
		private	byte	byteP2;
		private	byte[]	baData;
		private	byte	longitud;	

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="bCla">Class byte</param>
		/// <param name="bIns">Instruction byte</param>
		/// <param name="bP1">Parametro P1 byte</param>
        /// <param name="bP2">Parametro P2 byte</param>
		/// <param name="baData">Datos a enviar a la tarjeta, o null si no hay ninguno</param>
		/// <param name="bLe">Número de datos a enviar, 0 si es ninguno</param>
		public	ComandoTarjeta(byte bCla, byte bIns, byte bP1, byte bP2, byte bLe, byte[] baData)
		{
			this.byteCla = bCla;
			this.byteIns = bIns;
            this.byteP1 = bP1;
            this.byteP2 = bP2;
            this.baData = baData;
            this.longitud = bLe;
		}


        #region Métodos_GET
        /// <summary>
		/// Metodo get Class
		/// </summary>
		public	byte Class
		{
			get
			{
				return byteCla;
			}
		}


		/// <summary>
        /// Metodo get Instrucción
		/// </summary>
		public byte	Ins
		{
			get
			{
				return byteIns;
			}
		}


		/// <summary>
        /// Metodo get byte P1
		/// </summary>
		public byte	P1
		{
			get
			{
				return byteP1;
			}
		}


		/// <summary>
        /// Metodo get byte P2
		/// </summary>
		public byte P2
		{
			get
			{
				return byteP2;
			}
		}


		/// <summary>
        /// Metodo get Datos
		/// </summary>
		public byte[] Data
		{
			get
			{
				return baData;
			}
		}


		/// <summary>
        /// Metodo get Longitud
		/// </summary>
		public byte	Length
		{
			get
			{
				return longitud;
			}
        }
        #endregion

        /// <summary>
        /// To String();
        /// </summary>
        /// <returns>String Con el formato deseado</returns>
        public override string ToString()
        {
            string strData = null;
            byte bLc = 0, bP3 = longitud;    
            /* Comprobacion si hay datos en el mensaje*/
            if (baData != null)
            {
                StringBuilder sData = new StringBuilder(baData.Length * 2);
                // Pasamos a Hexadecimal
                for (int i = 0; i < baData.Length; i++)
                    sData.AppendFormat("{0:X02}", baData[i]);

                strData = sData.ToString();
                bLc = (byte) baData.Length;
                bP3 = bLc;
            }

            StringBuilder str = new StringBuilder();
            // Concatenacion de los Bytes INS-CLA-P1-P2-LE-DATA en hexadecimal.
            str.AppendFormat("{0:X02}{1:X02}{2:X02}{3:X02}{4:X02}",
                byteCla, byteIns, byteP1, byteP2, bP3);
            if (baData != null)
                str.Append(strData);

            return str.ToString();
        }
    }
}
