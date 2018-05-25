using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

//using OpenCVDotNet;
using Cognitec.FRsdk;
using Face = Cognitec.FRsdk.Face;
using Eyes = Cognitec.FRsdk.Eyes;
using Portrait = Cognitec.FRsdk.Portrait;
using FullFrontal = Cognitec.FRsdk.ISO_19794_5.FullFrontal;
using Feature = Cognitec.FRsdk.Portrait.Feature;
using System.IO;
using System.Threading;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;


namespace ClienteCara
{
    delegate void EnableLabelDelegate(bool tarj);
    public partial class Form1 : Form
    {
        public string ultimoMsg = "";        
        CardBase micard;
        static bool tarjeta;
        static string lectora;
        static string respuesta;
        
        string usuario_tarjeta;
        bool tarjetaOn = false;
        private Capture capture;
        private int contador;
        private int contador2;
        private int numIntentos;

        public Form1()
        {
            capture = new Capture();
            capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 640);
            capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 420);
            InitializeComponent();
            contador = 0;
            contador2 = 0;
            numIntentos = 0;            
            tarjeta = false;
            respuesta = "";
            lectora = "";
            ultimoMsg = "";
            usuario_tarjeta = "desconocido";
            SelectICard();
            
        }

        public void Mensajes(string msg)
        {
            this.labelEstado.Text = msg;
            this.labelEstado.Refresh();
        }

        private void SelectICard()
        {
            try
            {
                //si ya está inicializada
                if (micard != null)
                    micard.Disconnect(DISCONNECT.Unpower);

                //Inicialización
                micard = new CardNative();
                micard.OnCardInserted += new CardInsertedEventHandler(miCard_OnCardInserted);
                micard.OnCardRemoved += new CardRemovedEventHandler(miCard_OnCardRemoved);

            }
            catch (System.Exception)
            {
                MessageBox.Show("Error al inicializar");
            }

            String[] readers = micard.ListReaders();
            lectora = "SCM Microsystems Inc. SDI010 Contactless Reader 0";
            micard.StartCardEvents(lectora);

        }

        public bool envioDatos(Byte[] parametros, byte[] datosBytes)
        {
            micard.Connect(lectora, SHARE.Shared, PROTOCOL.T0orT1);     //IMPORTANTE

            respuesta = "";
            //Se intenta enviar el comando en bytes previamente creado a la tarjeta
            try
            {
                //Creación del comando
                ComandoTarjeta comando = new ComandoTarjeta(parametros[0], parametros[1], parametros[2], parametros[3], parametros[4], datosBytes);

                RespuestaTarjeta resp = micard.Transmit(comando); // Transmitimos el comando y recibimos la respuesta a éste.

                respuesta = tramitaRespuesta(resp);

                if (respuesta == "error")
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (System.Exception)
            { return false; }
        }

        private string tramitaRespuesta(RespuestaTarjeta resp)
        {
            string resultado = "";
            string SW = string.Format("{0:X02}", resp.SW1) + string.Format("{0:X02}", resp.SW2);

            if (SW != "9000")
            {
                return "error";
            }
            else
            {
                if (resp != null)
                {
                    if (resp.Data != null)
                    {
                        StringBuilder datos = new StringBuilder(resp.Data.Length * 2);
                        //Pasamos a hexadecimal los datos que contiene el array.
                        for (int i = 0; i < resp.Data.Length; i++)
                        {
                            datos.AppendFormat("{0:X02}", resp.Data[i]);

                        }
                        resultado = datos.ToString();
                    }
                }

                return resultado;
            }
        }

        protected void EnableLabel(bool tarj)
        {
            if (tarjetaOn == false)
            {   
                tarjetaOn = true;
                tarjeta = tarj;
                labelUsuario.Visible = true;
                usuario_tarjeta = comprobarIdSistema();
                labelUsuario.Text = usuario_tarjeta;
                labelUsuario.Refresh();
                if ((usuario_tarjeta.CompareTo("NO SE DETECTA TARJETA") == 0) || (usuario_tarjeta.CompareTo("ERROR DE COMUNICACIÓN") == 0) || (usuario_tarjeta.CompareTo("TARJETA INCORRECTA") == 0)) return;
                string IDCara = leerIdFacial();
                timer1.Enabled = true;
                
            }

        }

        protected void DisableLabel(bool tarj)         
        {

            numIntentos = 0;
            tarjetaOn = false;
            labelUsuario.Text = "";
            labelUsuario.Visible = false;
            timer1.Enabled = false;            
            tarjeta = false;
            respuesta = "";
            lectora = "";
            ultimoMsg = "";
            usuario_tarjeta = "desconocido";
            labelEstado.Text = "ACERQUE SU TARJETA";
            pictureBox2.Visible = false;       
            pictureBox1.Load(@"..\..\Resources\CardMan-5321_free.jpg");
            pictureBox1.Refresh();
            SelectICard();
            
        }        


        #region EVENTOS TARJETA
        /// <summary>
        /// Evento que se dispara al insertar la tarjeta
        /// </summary>
        private void miCard_OnCardInserted()
        {
            Invoke(new EnableLabelDelegate(EnableLabel), new object[] { true });

        }

        /// <summary>
        /// Evento que se dispara al extraer la tarjeta.
        /// </summary>
        private void miCard_OnCardRemoved()
        {
            Invoke(new EnableLabelDelegate(DisableLabel), new object[] { false });

        }

        #endregion

        public bool hayTarjeta()
        {
            if (!tarjeta)
            {
                return false;
            }
            else { return true; }
        }

        public bool cargaClave()
        {
            if (!hayTarjeta())
                return false;

            byte[] parametrosCarga = new byte[5] { 0xFF, 0x82, 0x00, 0x61, 0x06 };    //cargar clave
            byte[] datosIni = new byte[6] { 0x07, 0x08, 0x09, 0x10, 0x11, 0x12 };

            if (!envioDatos(parametrosCarga, datosIni))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public bool autentica(byte block)
        {
            if (!hayTarjeta())
                return false;

            byte[] datosAut = new byte[5] { 0x01, 0x00, block, 0x61, 0x01 };

            byte[] parametrosAut = new byte[5] { 0xFF, 0x86, 0x00, 0x00, 0x05 };    //autenticarse             

            if (!envioDatos(parametrosAut, datosAut))
            {
                return false;
            }
            else 
            {
                return true;
            }

        }

        private string leerId(byte dccion)
        {
            if (!hayTarjeta())
                return "";

            string Idrespuesta = "";

            cargaClave();
            autentica(dccion);

            byte[] datosId = new byte[0];
            byte[] parametrosEscr = new byte[5] { 0xFF, 0xB0, 0x00, dccion, 0x10 };    //leer 

            if (!envioDatos(parametrosEscr, datosId)) { }
            else
            {
                Idrespuesta = convierte_a_ASCII(respuesta);

            }
            return Idrespuesta;
        }

        #region METODOS CAMBIO FORMATO
        /// <summary>
        /// Pasa un numero en Hexadecimal a su equivalente en Byte
        /// </summary>
        /// <param name="hex">Cadena de texto con el numero en Hexadecimal </param>
        /// <returns>Equivalente en formato Byte</returns>
        private byte pasaABytes(string hex)
        {
            byte b;
            try
            {

                int value = Convert.ToInt32(hex, 16); // Conversion a entero.
                b = Convert.ToByte(value);
            }
            catch (System.Exception)
            {
                throw new System.Exception("Error en el formato de los datos de entrada. Solo 1 Byte por campo");
            }
            return b;

        }

        /// <summary>
        /// Pasa a un array de bytes, una cadana en Hexadecimal
        /// </summary>
        /// <param name="hex">Cadena con los datos en Hexadecimal</param>
        /// <returns>Array de Bytes equivalente</returns>
        private byte[] pasaABytesARRAY(string hex)
        {
            byte[] b;
            try
            {
                // Inicializamos nuestro array
                b = new byte[hex.Length / 2];
                int i = 0;
                int j = 0;
                for (i = 0, j = 0; i < hex.Length; j++)
                {
                    string aux = hex.Substring(i, 2); // Tomamos el dato
                    int value = Convert.ToInt32(aux, 16); // Conversion a entero.
                    b[j] = Convert.ToByte(value);
                    i = i + 2;
                }
            }
            catch (System.Exception)
            {
                throw new System.Exception(" en el formato de los datos de entrada");
            }
            return b;

        }

        /// <summary>
        /// Convierte a ASCII una cadena en HEXADECIMAL
        /// </summary>
        /// <param name="Hexadecimal">Cadena en formato Hexadecimal</param>
        /// <returns>Cadena convertida a caracteres ASCII</returns>
        private string convierte_a_ASCII(String Hexadecimal)
        {
            String ASCII = "";
            for (int i = 0; i < Hexadecimal.Length; )
            {
                //SE TOMAN DE 2 EN 2    
                int aux = Convert.ToInt32(Hexadecimal.Substring(i, 2), 16);
                string stringValue = Char.ConvertFromUtf32(aux);
                ASCII += stringValue;
                i += 2;
            }
            return ASCII;

        }

        /// <summary>
        /// Convierte a Hexadecimal una cadena ASCII
        /// </summary>
        /// <param name="ASCII">Cadena de caracteres ASCII</param>
        /// <returns>Cadena en formato hexadecimal</returns>
        private string convierteAHexadecimal(String ASCII)
        {
            string hex = "";
            char[] values = ASCII.ToCharArray();
            foreach (char letter in values)
            {
                // Obtenemos el valor
                int value = Convert.ToInt32(letter);
                // Conversion a hexadecimal
                hex += String.Format("{0:X}", value);
            }
            return hex;
        }

        /// <summary>
        ///  Metodo para pasar un array de Bytes a Hexadecimal
        /// </summary>
        /// <param name="data">Array de Bytes con los datos a convertir</param>
        /// <returns>String con los bytes pasados a String.</returns>
        static private string ByteArrayToString(byte[] data)
        {
            StringBuilder datos;

            if (data != null)
            {
                // Se crea la cadena con la longitud necesaria y se va convirtiendo cada posición
                // del array.
                datos = new StringBuilder(data.Length * 2);
                for (int i = 0; i < data.Length; i++)
                    datos.AppendFormat("{0:X02}", data[i]);
            }
            else
                datos = new StringBuilder();

            return datos.ToString();
        }

        #endregion


        public string leerIdUsuario()
        {
            return leerId(0x02);
        }

        public string leerIdVenas()
        {
            string dev = leerId(0x04);
            dev = dev.Remove(dev.IndexOf("\0"));
            return dev;
        }
        public string leerIdFacial()
        {
            string dev = leerId(0x08);
            dev = dev.Remove(dev.IndexOf("\0"));
            return dev;
        }

        public string comprobarIdSistema()
        {
            if (!hayTarjeta())
            {
                return "NO SE DETECTA TARJETA";
            }

            bool aux = cargaClave();
            bool aux2 = autentica(0x01);

            byte[] datosClave = new byte[0];
            byte[] parametrosEscr = new byte[5] { 0xFF, 0xB0, 0x00, 0x01, 0x10 };    //leer 

            //la clave del sistema será: 0x677574697563336D677574697563336D  (gutiuc3mgutiuc3m)

            if (!envioDatos(parametrosEscr, datosClave))
            {
                return "ERROR DE COMUNICACIÓN";
            }
            else
            {
                string miUsr = leerIdUsuario();
                miUsr = miUsr.Remove(miUsr.IndexOf("\0"));
                cargaClave();
                autentica(0x01);
                envioDatos(parametrosEscr, datosClave);

                if (respuesta == "677574697563336D677574697563336D")
                {
                    return miUsr;
                }
                else
                {
                    return "TARJETA INCORRECTA";
                }

            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int resultado;
            labelEstado.Visible = true;

            using (Image<Bgr, Byte> nextFrame = capture.QueryFrame())
            {
                pictureBox1.Image = nextFrame.ToBitmap();
                if (contador == 10)
                {    //Cada 2 segundos.
                    contador = 0;
                    pictureBox1.Image.Save("prueba.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    resultado = analizarImagen();
                    if (resultado == 0)
                    {
                        pictureBox2.Visible = false;
                        contador2 = 0;
                        timer1.Enabled = false;
                        labelEstado.Visible = false;
                        labelEstado.Refresh();
                        labelEstado.Text = "CAPTURA REALIZADA                ";                        
                        labelEstado.Visible = true;
                        labelEstado.Refresh();
                        labelEstado.Visible = true;
                        
                        byte[] miMuestra = LoadFile("prueba.jpg");
                        Cliente_Cara.ServiceReference1.Service1SoapClient miServicio = new Cliente_Cara.ServiceReference1.Service1SoapClient();
                        string usu = leerIdFacial();
                        //usu = usu.Remove(usu.IndexOf("\0"));
                        int mierror = miServicio.WS_Verify_Cara(miMuestra, usu);
                        if (mierror == 0)
                        {
                            labelEstado.Text = "EXITO                    ";
                            labelEstado.Refresh();
                            pictureBox2.Load(@"..\..\Resources\agt_action_success.png");
                            pictureBox2.Visible = true;
                            pictureBox2.Refresh();
                            numIntentos = 0;
                           
                        }
                        if (mierror == -1)
                        {
                            if (numIntentos < 2)
                            {
                                labelEstado.Text = "RECHAZO                  ";
                                labelEstado.Refresh();
                                pictureBox2.Load(@"..\..\Resources\button_cancel.png");
                                pictureBox2.Visible = true;
                                pictureBox2.Refresh();
                                numIntentos++;
                                timer1.Enabled = true;
                            }
                            else {
                                labelEstado.Text = "LIMITE DE INTENTOS             ";
                                labelEstado.Refresh();
                                pictureBox2.Load(@"..\..\Resources\button_cancel.png");
                                pictureBox2.Visible = true;
                                pictureBox2.Refresh();
                                numIntentos = 0;
                            
                            }
                         
                            
                        }
                        if (mierror == -2)
                        {
                            labelEstado.Text = "ERROR DE SISTEMA                  ";
                            pictureBox2.Load(@"..\..\Resources\button_cancel.png");
                            pictureBox2.Visible = true;
                            labelEstado.Refresh();
                        }

                        // AQUI TENEMOS QUE MANDAR LA FOTO Y EL IDENTIFICADOR AL SERVIDOR

                    }
                    
                   else if (resultado == -1)
                    {
                        //label32.Text = "Excepción";
                        //label32.Refresh();

                    }
                    else if (resultado == -2)
                    {
                        labelEstado.Text = "MIRE A LA CÁMARA            ";
                        labelEstado.Refresh();

                    }
                    else if (resultado == -3)
                    {
                        labelEstado.Text = "MIRE A LA CÁMARA            ";
                        labelEstado.Refresh();

                    }
                    else if (resultado == -4)
                    {
                        labelEstado.Text = "ACÉRQUESE A LA CÁMARA            ";
                        labelEstado.Refresh();

                    }

                }
                if (contador2 == 650)
                {
                    labelEstado.Text = "TIEMPO EXCEDIDO         ";
                    labelEstado.Refresh();
                    contador2 = 0;
                    contador = 0;
                    pictureBox1.Load(@"..\..\Resources\CardMan-5321_free.jpg");
                    timer1.Enabled = false;
                }
                contador++;
                contador2++;
            }
        }
        private byte[] LoadFile(string filename)
        {
            byte[] data = null;
            try
            {
                // get the exact file name from the path
                String strFile = System.IO.Path.GetFileName(filename);

                // get the file information form the selected file
                FileInfo fInfo = new FileInfo(filename);

                // get the length of the file to see if it is possible
                // to upload it (with the standard 4 MB limit)
                long numBytes = fInfo.Length;
                double dLen = Convert.ToDouble(fInfo.Length / 1000000);

                // Default limit of 4 MB on web server
                // have to change the web.config to if
                // you want to allow larger uploads
                if (dLen < 4)
                {
                    // set up a file stream and binary reader for the
                    // selected file
                    FileStream fStream = new FileStream(filename,
                    FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fStream);

                    // convert the file to a byte array
                    data = br.ReadBytes((int)numBytes);
                    br.Close();

                    // pass the byte array (file) and file name to the web service
                    // string sTmp = srv.UploadFile(data, strFile);
                    fStream.Close();
                    fStream.Dispose();

                }
                else
                {
                    // Display message if the file was too large to upload
                    MessageBox.Show("The file selected exceeds the size limit for uploads.", "File Size");
                }
            }
            catch (IOException ex)
            {
                // display an error message to the user
                MessageBox.Show(ex.Message.ToString(), "Upload Error");
            }
            return data;
        }
        private int analizarImagen()
        {

            //pictureBox1.Image.Save("prueba.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            // initialisation of configuration
            try
            {
                //Configuration cfg = new Configuration(@"..\..\License\frsdk.cfg");
                Configuration cfg = new Configuration(@"frsdk.cfg");
                float minrEyeDist = 0.1F;
                // face finder instantiation
                Face.Finder faceFinder = new Face.Finder(cfg);
                // eyes finder instantiation
                Eyes.Finder eyesFinder = new Eyes.Finder(cfg);
                // portrait analyzer instantiation
                Portrait.Analyzer portraitAnalyzer = new Portrait.Analyzer(cfg);
                // Feature assessment instantiation
                Feature.Test featureTest = new Feature.Test(cfg);
                // ISO 19794-5 Full Frontal image assessment instantiation
                FullFrontal.Test fullFrontalTest = new FullFrontal.Test(cfg);
                // load jpeg image
                Cognitec.FRsdk.Image img = Jpeg.load("prueba.jpg");

                Face.Location[] faceLocations = faceFinder.find(img, minrEyeDist, 0.4F, int.MinValue / 2, int.MinValue / 2, int.MaxValue / 2 - 1, int.MaxValue / 2 - 1);
                if (faceLocations.Length != 1)
                {
                    return -2;  // Si no encuentra una cara devuelve -2 
                }

                // iterate over face locations
                foreach (Face.Location faceLoc in faceLocations)
                {
                    // find eyes
                    Eyes.Location[] eyesLocations = eyesFinder.find(img, faceLoc);
                    // iterate over eyes locations                    
                    // do we have eyes found
                    if (eyesLocations.Length > 0)
                    {

                        if (faceLoc.width < 60)
                        {
                            return -4; //DEMASIADO LEJOS
                        }
                        // analyze portrait
                        Portrait.Characteristics portraitCharacteristics =
                          portraitAnalyzer.analyze
                          (new AnnotatedImage(img, eyesLocations[0]));


                        // test features
                        Feature.Set features = featureTest.assess(portraitCharacteristics);


                    }
                    else
                    {
                        return -3;// No encuentra los ojos
                    }

                }

                return 0; //Caso desconocido
            }

            catch (System.Exception)
            {
                return -1; // Excepcion
            }

        }

       

        private void botonCerrarClick(object sender, EventArgs e)
        {         

            //Compruebo que el "dbeng9.exe" esta funcionando si es así matamos
            //el proceso.
            string NomProcess = "Cliente Cara";
            string proceso_kill = NomProcess;

            foreach (Process my_proceso in Process.GetProcesses())
            {
                if (my_proceso.ProcessName.Contains(proceso_kill))
                {
                    my_proceso.Kill();
                }
            }


            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            micard.StopCardEvents();
            micard.Disconnect(DISCONNECT.Unpower);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        

                
    }
}
