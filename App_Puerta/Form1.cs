using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EikonLibrary;
using EikonTouchLibrary;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.UI;
using System.IO;

namespace App_Puerta
{
    public partial class App_Puerta : Form
    {
        //Capture capture;
        string user;
        string pass;
        string mediaType;
        string IP;
        string dirCaras = "../../caras";
        string dirHuellas = "../../huellas";
        string dirUsuarios = "../../usuarios.txt";        
        string id;
        string escenario1;
        string escenario3;
        string reclutamiento;
        string verificacion1;
        string verificacion2;
        int numMuestras;


        public App_Puerta()
        {
            InitializeComponent();
            //capture = new Capture();
            //capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 720);      //720
            //capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 500);       //500            
            //capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_CONVERT_RGB, 0);
            textBox_nombre.Text = "1";
            textBox_ID.Text = "1";
            user = "root";
            pass = "admin";
            mediaType = "mjpeg";
            IP = "10.10.10.104"; // LEER DE FICHERO            
            id = "";            
            log("Inicio de la app");
            numMuestras = 5;
            escenario1 = "001";
            escenario3 = "003";
            reclutamiento = "RE";
            verificacion1 = "V1";
            verificacion2 = "V2";
        }

        /* EVENTOS DE BOTÓN */


        //PANEL DE INICIO

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            Controles.SelectedTab = tab_reclutamiento;
            panel_ID.Enabled = true;
        }

        private void button_existente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_nombre_inicio.Text) || textBox_nombre_inicio.Text.Any(x => char.IsLetter(x)))
            {
                MessageBox.Show("Por favor, introduce un DNI sin letra");
            }
            else
            {
                // AQUÍ HAY QUE COMPROBAR QUE ESTÉ EN LA BD Y QUÉ TIENE COMPLETADO (V1 / V2)
                textBox_nombre_inicio.Text = "";
                Controles.SelectedTab = tab_visita2;
                //HABILITAR LA CÁMARA 
                panel_cara_v2.Enabled = true;
            }
        }

        private void button_habilitar_Click(object sender, EventArgs e)
        {
            panel_ID.Enabled = true;
            panel_cara.Enabled = true;
            panel_huella.Enabled = true;
            panel_cara_v1.Enabled = true;
            panel_huella_v1.Enabled = true;
            panel_cara_v2.Enabled = true;
            panel_huella_v2.Enabled = true;
        }

        //RECLUTAMIENTO

        private void button_ID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_nombre.Text) || string.IsNullOrWhiteSpace(textBox_ID.Text) || textBox_ID.Text.Any(x => char.IsLetter(x)))
            {
                MessageBox.Show("Por favor, introduce nombre y DNI sin letra");
            }
            else
            {
                if (registro(textBox_nombre.Text, textBox_ID.Text) > 0)
                {
                    panel_huella.Enabled = true;
                }
                else if (registro(textBox_nombre.Text, textBox_ID.Text) == -1) {
                    MessageBox.Show("Error al crear el usuario");
                }
                else if (registro(textBox_nombre.Text, textBox_ID.Text) == -2)
                {
                    MessageBox.Show("El usuario ya está en la base de datos");
                }

            }
        }

        private void button_huella_Click(object sender, EventArgs e)
        {
            //String huella = capturaHuella();
        }

        private void button_huella_siguiente_Click(object sender, EventArgs e)
        {

            iniciarCamara();

            //COMPROBAR QUE TENEMOS TODAS LAS HUELLAS, SI NO, AVISAR!
            //HABILITAR LA CÁMARA            
            panel_cara.Enabled = true;
        }

        private void button_final_reclutamiento_Click(object sender, EventArgs e)
        {
            //COMPROBAR QUE TENEMOS TODAS LAS CARAS, SI NO, AVISAR!
            //DESHABILITAR LA CÁMARA            
            panel_huella_v1.Enabled = true;
            Controles.SelectedTab = tab_visita1;
        }

        //VISITA 1

        private void button_huella_siguiente_v1_Click(object sender, EventArgs e)
        {
            //COMPROBAR QUE TENEMOS TODAS LAS HUELLAS, SI NO, AVISAR!
            //HABILITAR LA CÁMARA            
            panel_cara_v1.Enabled = true;
        }

        private void button_final_v1_Click(object sender, EventArgs e)
        {
            //COMPROBAR QUE TENEMOS TODAS LAS CARAS, SI NO, AVISAR!
            //DESHABILITAR LA CÁMARA 
            MessageBox.Show("Fin de la visita 1. Continue en el móvil");
            Controles.SelectedTab = tab_inicio;
        }

        //VISITA 2

        private void button_cara_siguiente_v2_Click(object sender, EventArgs e)
        {
            //COMPROBAR QUE TENEMOS TODAS LAS CARAS, SI NO, AVISAR!
            //DESHABILITAR LA CÁMARA
            panel_huella_v2.Enabled = true;
        }

        private void button_fin_Click(object sender, EventArgs e)
        {
            //COMPROBAR QUE TENEMOS TODAS LAS MUESTRAS, SI NO, AVISAR!
            MessageBox.Show("Fin de la visita 2. Continue en el móvil");
            Controles.SelectedTab = tab_inicio;
        }

        /********************/

        /* Reclutamiento de datos*/        
        private int registro(string nombre, string dni)
        {

            StreamReader sr = new StreamReader(dirUsuarios);
            String linea = "";
            String aux = "";
            String nuevo = "";
            String nuevoID = "";
            int numAnterior = 0;
            
            try {

                while ((aux = sr.ReadLine()) != null)
                {
                    linea = aux;
                    if (linea.Contains(nombre) || linea.Contains(id)) {
                        sr.Close();
                        return -2;
                    }
                }
                sr.Close();
            }
            catch (Exception e) {
                MessageBox.Show("Error en la lectura del fichero de usuarios" + e.ToString());
                log("Error en la lectura del fichero de usuarios");
                return -1;
            }

            if (linea == null || linea == "")
            {
                numAnterior = 1;
            }
            else {
                Int32.TryParse(linea.Substring(0, 3), out numAnterior);
                numAnterior = numAnterior + 1;
            }                
            
            if (numAnterior <= 9)
            {
                nuevoID = "00" + numAnterior;
            }
            else if (numAnterior > 9 && numAnterior < 99)
            {
                nuevoID = "0" + numAnterior;
            }
            else {
                nuevoID = "" + numAnterior;
            }

            try {

                StreamWriter sw = File.AppendText(dirUsuarios);
                nuevo = nuevoID + "_" + nombre + "_" + dni + "_";
                id = nuevoID;
                
                sw.WriteLine(nuevo);
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la escritura del fichero de usuarios" + e.ToString());
                log("Error en la escritura del fichero de usuarios");
                return -1;
            }

            log("Usuario " + nuevoID + " creado");
            return numAnterior;
        }



        /* Reconocimiento por HUELLA */

        public string capturaHuella()
        {

            unsafe
            {

                byte* capturedImage = (byte*)0;
                //capturedImage = new byte* { 200000 };
                int imageWidth, imageHeight;
                int codigoError = 0;

                try
                {
                    codigoError = EikonTouchClass.CaptureImage(10000, &imageWidth, &imageHeight, capturedImage);
                }
                catch (Exception e)
                {
                    return e.ToString() + "_errCode= " + codigoError;
                }
            }


            return "OK";
        }

        /********************/

        /* Reconocimiento FACIAL*/

        /* AXIS */

        private string CompleteURL(string theMediaURL, string theMediaType)
        {
            string anURL = theMediaURL;
            if (!anURL.EndsWith("/")) anURL += "/";

            if (theMediaType == "mjpeg")
            {
                anURL += "axis-cgi/mjpg/video.cgi";
            }
            else if (theMediaType == "mpeg4")
            {
                anURL += "mpeg4/media.amp";
            }
            else if (theMediaType == "h264")
            {
                anURL += "axis-media/media.amp?videocodec=h264";
            }
            else if (theMediaType == "mpeg2-unicast")
            {
                anURL += "axis-cgi/mpeg2/video.cgi";
            }
            else if (theMediaType == "mpeg2-multicast")
            {
                anURL += "axis-cgi/mpeg2/video.cgi";
            }

            anURL = CompleteProtocol(anURL, theMediaType);
            return anURL;
        }

        private string CompleteProtocol(string theMediaURL, string theMediaType)
        {
            if (theMediaURL.IndexOf("://") >= 0) return theMediaURL;

            string anURL = theMediaURL;

            if (theMediaType == "mjpeg")
            {
                anURL = "http://" + anURL;
            }
            else if (theMediaType == "mpeg4" || theMediaType == "h264")
            {
                anURL = "axrtsphttp://" + anURL;
            }
            else if (theMediaType == "mpeg2-unicast")
            {
                anURL = "http://" + anURL;
            }
            else if (theMediaType == "mpeg2-multicast")
            {
                anURL = "axsdp" + anURL;
            }

            return anURL;
        }

        public bool iniciarCamara()
        {

            try
            {
                axAxisMediaControl_R.MediaUsername = user;
                axAxisMediaControl_R.MediaPassword = pass;
                axAxisMediaControl_R.MediaType = mediaType;
                axAxisMediaControl_R.MediaURL = CompleteURL(IP, mediaType);
                axAxisMediaControl_R.Play(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede mostrar el stream: " + ex.Message);
            }

            return true;
        }

        public bool capturarCara(string fase)
        {

            //Obtención de imagen
            int muestra = 1;
            int resultado = 1;

            string nombreArchivo = id + "_" + escenario1 + "_" + "00"+ muestra + "_" + fase + "_" + resultado + ".png";
            string nombreArchivo2 = id + "_" + escenario1 + "_" + "00" + muestra + "_" + fase + "_" + resultado + "Aux.png";
            
            string idB = caras + nombre + "B.bmp";
            string idB2 = caras + nombre + "AuxB" + ".png";


            if(fase.Equals("RE"))
           

            axAxisMediaControl1.SaveCurrentImage(0, id2);

                Thread.Sleep(500);

                Bitmap x = (Bitmap)System.Drawing.Image.FromFile(id2);
                System.Drawing.Image x2 = x.Clone(new Rectangle(200, 100, 240, 320), x.PixelFormat);
                x2.Save(id, ImageFormat.Bmp);

                int rec = reclutamiento(id);

                if (rec < -4)
                {
                    try
                    {
                        // Stop the stream (will also stop any recording in progress).                
                        Thread.Sleep(500);
                        axAxisMediaControl1.Stop();
                        axAxisMediaControl1.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    OKfacial.Visible = true;
                    OKfacial.Refresh();

                    enrollment(caras + nombre + ".bmp", caras + nombre + ".fir");

                }

                imageEnrol.Load(id);
                imageEnrol.Refresh();
                imageEnrol.Visible = true;
            }

            else
            {
                axAxisMediaControl2.SaveCurrentImage(0, idB2);

                Thread.Sleep(500);

                Bitmap xB = (Bitmap)System.Drawing.Image.FromFile(idB2);
                System.Drawing.Image xB2 = xB.Clone(new Rectangle(200, 100, 240, 320), xB.PixelFormat);
                xB2.Save(idB, ImageFormat.Bmp);

                int recB = reclutamiento(idB);

                if (recB < -4)
                {
                    try
                    {
                        // Stop the stream (will also stop any recording in progress).                
                        Thread.Sleep(500);
                        axAxisMediaControl2.Stop();
                        axAxisMediaControl2.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //OKfacial.Visible = true;
                    //OKfacial.Refresh();

                    //enrollment(caras + nombre + ".bmp", caras + nombre + ".fir");

                    int err = verification(caras, nombre, idB);

                    imagenRecog.Load(idB);
                    imagenRecog.Refresh();
                    imagenRecog.Visible = true;

                    if (err != 0)
                    {
                        MessageBox.Show("Usuario desconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Hola " + nombre + '\n' + '\n' + "Temperatura: " + temperatura + "ºC" + '\n' + "Humedad: " + humedad + "%", "Habitación Principal", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        recogNombre.Text = nombre;
                        recogTemp.Text = temperatura + "ºC";
                        recogHum.Text = humedad + "%";
                    }

                }


            }




        }*/


        /********************/



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void huella_result_5_v2_Click(object sender, EventArgs e)
        {

        }

        private void huella_result_4_v2_Click(object sender, EventArgs e)
        {

        }

        private void huella_result_3_v2_Click(object sender, EventArgs e)
        {

        }

        private void huella_result_2_v2_Click(object sender, EventArgs e)
        {

        }

        private void huella_result_1_v2_Click(object sender, EventArgs e)
        {

        }
        
        private void label_huellas_reclutamiento_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        

        private void button_borrar_huella_Click(object sender, EventArgs e)
        {

        }

        private void button_borrar_huellas_Click(object sender, EventArgs e)
        {

        }

        private void button_borrar_cara_v1_Click(object sender, EventArgs e)
        {

        }

        private void button_borrar_caras_v1_Click(object sender, EventArgs e)
        {

        }

        private void cara_result_1_v1_Click(object sender, EventArgs e)
        {

        }

        private void cara_result_2_v1_Click(object sender, EventArgs e)
        {

        }

        private void cara_result_3_v1_Click(object sender, EventArgs e)
        {

        }

        private void cara_result_4_v1_Click(object sender, EventArgs e)
        {

        }

        private void cara_result_5_v1_Click(object sender, EventArgs e)
        {

        }

        private void axAxisMediaControl_V2_OnError(object sender, AxAXISMEDIACONTROLLib._IAxisMediaControlEvents_OnErrorEvent e)
        {

        }

        /* LOG */
        public void log(string logMessage)
        {
            StreamWriter w = File.AppendText("log.txt");
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
            w.Close();
        }
    }
}
