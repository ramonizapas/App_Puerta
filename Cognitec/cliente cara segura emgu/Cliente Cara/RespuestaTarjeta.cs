using System;
using System.Text;

namespace ClienteCara
{
	/// <summary>
	/// Representacion de una respuesta de la tarjeta.
	/// </summary>
	public class RespuestaTarjeta
	{
		/// <summary>
		///	Longitud de los bytes SW
		/// </summary>
		public const int SW_LENGTH = 2;		

		private byte[]	m_baData = null;	
		private byte	Sw1;
		private byte	Sw2;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="baData">Buffer de datos de la tarjeta.</param>
		public RespuestaTarjeta(byte[] baData)
		{
			if (baData.Length > SW_LENGTH)
			{
				m_baData = new byte[baData.Length - SW_LENGTH];

				for (int i = 0; i < baData.Length - SW_LENGTH; i++)
					m_baData[i] = baData[i];
			}

			Sw1 = baData[baData.Length - 2];
			Sw2 = baData[baData.Length - 1];
        }

        #region METODOS GET
        /// <summary>
		/// Response data get property. Contains the data sent by the card minus the 2 status bytes (SW1, SW2)
		/// null if no data were sent by the card
		/// </summary>
		public	byte[]	Data
		{
			get
			{
				return m_baData;
			}
		}

		/// <summary>
		/// SW1 byte get property
		/// </summary>
		public byte	SW1
		{
			get
			{
				return Sw1;
			}
		}

		/// <summary>
		/// SW2 byte get property
		/// </summary>
		public byte	SW2
		{
			get
			{
				return Sw2;
			}
		}

		/// <summary>
		/// Status get property
		/// </summary>
	/*	public	ushort	Status
		{
			get
			{
				return (ushort) (((short) Sw1 << 8) + (short) Sw2);
			}
        }
        */
        #endregion 
        /// <summary>
        /// Metodo ToString_ que devuelve en un array la respuesta y el SW de la tarjeta.
        /// </summary>
        /// <returns>Array de String donde la posicion 0 son los datos de la respuesta de la tarjeta y la pósicion
        /// segunda es el SW.
        /// </returns>
        public string[] ToString_()
        {
            string respuesta;
    
            // R: Datos 

            respuesta = "R:";
            if (m_baData != null)
            {
                StringBuilder sData = new StringBuilder(m_baData.Length * 2);
                for (int nI = 0; nI < m_baData.Length; nI++)
                    sData.AppendFormat("{0:X02}", m_baData[nI]);

                respuesta += sData.ToString();
            }
            //SW: XXXX
            String SW = string.Format("SW:{0:X02}{1:X02}", SW1,SW2);
            return new string[]{respuesta,SW};
        }
	}
}
