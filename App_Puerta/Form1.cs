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
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Flann;
using Emgu.CV.Util;

using System.IO;
using System.Drawing.Imaging;
using System.Threading;
using System.Runtime.InteropServices;

namespace App_Puerta
{
    public partial class App_Puerta : Form
    {
        Capture capture;
        string user;
        string pass;
        string mediaType;
        string IP;
        string dirCaras = @"caras\";
        string dirLibCaras = "haarcascade_frontalface_alt_tree.xml";        
        string dirHuellas = @"huellas\";
        string dirUsuarios = @"usuarios.txt";
        string formatoCaras = ".png";
        string formatoHuellas = ".bmp";
        string id;
        string escenario1;
        string escenario3;
        string reclutamiento;
        string verificacion1;
        string verificacion2;
        int numMuestras;
        HaarCascade haar;
        string IPcam;


        public App_Puerta()
        {
            InitializeComponent();
            //capture = new Capture();            
            //capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 720);      //720
            //capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 500);       //500            
            //capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_CONVERT_RGB, 0);
            textBox_nombre.Text = "p";
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
            //Classifier = new CascadeClassifier(dirLibCaras);
            haar = new HaarCascade(dirLibCaras);
            IPcam = "http://root:admin@10.10.10.104/axis-cgi/mjpg/video.cgi?x.mjpeg";            
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

            //ID
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
                    button_ID.Enabled = false;
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

            //HUELLA

        private void button_huella_Click(object sender, EventArgs e)
        {
            int muestra = 1;
            int resultado = 1;                        
            int labelHuella = Int32.Parse(label_huellas_reclutamiento.Text);

            string[] huellasPrevias = Directory.GetFiles(dirHuellas, id + "*").Select(Path.GetFileName).ToArray();

            if (huellasPrevias.Length == 5)
            {
                MessageBox.Show("Reclutamiento de huella terminado, haga click en Siguiente");
                return;
            }

            if (huellasPrevias.Length == 0)
            {
                muestra = 1;
            }
            else {
                muestra = huellasPrevias.Length + 1;
            }

            string muestraPadZeros = "" + muestra;
            muestraPadZeros = muestraPadZeros.PadLeft(3, '0');

            string nombreArchivo = id + "_" + escenario1 + "_" + muestraPadZeros + "_" + "RE" + "_" + resultado + formatoHuellas;
            
            Bitmap bitmapHuella = capturaHuella();            
            bitmapHuella.Save(dirHuellas + nombreArchivo, ImageFormat.Bmp);
            pictureBox_huella_reclutamiento.Image = bitmapHuella;
            labelHuella = labelHuella + 1;
            label_huellas_reclutamiento.Text = "" + labelHuella;

            if (muestra == 5) {

                MessageBox.Show("Fin del reclutamiento de huella, haga click en Siguiente");
                button_huella.Enabled = false;
            }            
        }

        private void button_borrar_huella_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Borrar la última huella? Esto no puede deshacerse", "BORRAR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //string[] huellasPrevias = Directory.GetFiles(dirHuellas, id + "*").Select(Path.GetFileName).ToArray();

                DirectoryInfo d = new DirectoryInfo(dirHuellas);
                FileInfo ultima = d.GetFiles().OrderByDescending(f => f.LastWriteTime).First();
                ultima.Delete();
                MessageBox.Show("Última huella eliminada");
                button_huella.Enabled = true;
                int labelHuella = Int32.Parse(label_huellas_reclutamiento.Text);
                labelHuella = labelHuella - 1;
                label_huellas_reclutamiento.Text = "" + labelHuella;
            }
            else if (dialogResult == DialogResult.No)
            {
                //No hacer nada
            }
        }

        private void button_borrar_huellas_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Borrar todas las huellas del usuario? Esto no puede deshacerse", "BORRAR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DirectoryInfo d = new DirectoryInfo(dirHuellas);
                //string[] huellasPrevias = Directory.GetFiles(dirHuellas, id + "*").Select(Path.GetFileName).ToArray();

                foreach (FileInfo file in d.GetFiles())
                {
                    if (file.Name.Contains(id)) {
                        file.Delete();
                    }                    
                }
                MessageBox.Show("Huellas del reclutamiento eliminadas");
                button_huella.Enabled = true;
                label_huellas_reclutamiento.Text = "0";
            }
            else if (dialogResult == DialogResult.No)
            {
                //No hacer nada
            }
        }

        private void button_huella_siguiente_Click(object sender, EventArgs e)
        {
            //COMPROBAR QUE TENEMOS TODAS LAS HUELLAS, SI NO, AVISAR!
            //HABILITAR LA CÁMARA  
            iniciarCamara();
            //Thread.Sleep(500);
                      
            panel_cara.Enabled = true;
            button_huella_siguiente.Enabled = false;
            //timer_cara_reclutamiento.Enabled = true;
            //timer_cara_reclutamiento.Start();
        }

        //CARA

        private void button_cara_Click(object sender, EventArgs e)
        {
            capture = new Capture(IPcam);
            timer_cara_reclutamiento.Enabled = true;
            timer_cara_reclutamiento.Start();

        }

        private void button_borrar_cara_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Borrar la última cara? Esto no puede deshacerse", "BORRAR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DirectoryInfo d = new DirectoryInfo(dirCaras);
                FileInfo ultima = d.GetFiles().OrderByDescending(f => f.LastWriteTime).First();
                ultima.Delete();
                MessageBox.Show("Última cara eliminada");
                button_cara.Enabled = true;
                int labelCara = Int32.Parse(label_caras_reclutamiento.Text);
                labelCara = labelCara - 1;
                label_caras_reclutamiento.Text = "" + labelCara;
            }
            else if (dialogResult == DialogResult.No)
            {
                //No hacer nada
            }
        }

        private void button_borrar_caras_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Borrar todas las caras del usuario? Esto no puede deshacerse", "BORRAR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DirectoryInfo d = new DirectoryInfo(dirCaras);

                foreach (FileInfo file in d.GetFiles())
                {
                    if (file.Name.Contains(id))
                    {
                        file.Delete();
                    }
                }
                MessageBox.Show("Caras del reclutamiento eliminadas");
                button_cara.Enabled = true;
                label_caras_reclutamiento.Text = "0";
            }
            else if (dialogResult == DialogResult.No)
            {
                //No hacer nada
            }
        }

        private void timer_cara_reclutamiento_Tick(object sender, EventArgs e)
        {

            int muestra = 1;
            int resultado = 1;
            int labelCara = Int32.Parse(label_caras_reclutamiento.Text);            
            
            string[] carasPrevias = Directory.GetFiles(dirCaras, id + "*").Select(Path.GetFileName).ToArray();

            if (carasPrevias.Length == 5)
            {
                //MessageBox.Show("Reclutamiento terminado, haga click en Siguiente para comenzar la VISITA 1");
                //timer_cara_reclutamiento.Stop();
                timer_cara_reclutamiento.Stop();
                timer_cara_reclutamiento.Enabled = false;
                button_cara.Enabled = false;
                return;
            }

            else
            {
                if (carasPrevias.Length == 0)
                {
                    muestra = 1;
                }
                else
                {
                    muestra = carasPrevias.Length + 1;
                }

                string muestraPadZeros = "" + muestra;
                muestraPadZeros = muestraPadZeros.PadLeft(3, '0');

                string nombreArchivo = id + "_" + escenario3 + "_" + muestraPadZeros + "_" + "RE" + "_" + resultado + formatoCaras;

                Image<Bgr, Byte> currentFrame = capture.QueryFrame();


                if (currentFrame != null)
                {
                    Image<Gray, Byte> grayFrame = currentFrame.Convert<Gray, Byte>();
                    var detectedFaces = grayFrame.DetectHaarCascade(haar, 1.6, 4, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(grayFrame.Width / 8, grayFrame.Height / 8))[0];

                    if (detectedFaces.Length > 1)
                    {
                        MessageBox.Show("Más de una cara detectada");
                    }
                    else if (detectedFaces.Length == 1 && detectedFaces[0].rect.Width > 10)
                    {
                        currentFrame.ToBitmap().Save(dirCaras + nombreArchivo);
                        //foreach (var face in detectedFaces)
                        //currentFrame.Draw(face.rect, new Bgr(0, double.MaxValue, 0), 3);

                        pictureBox_cara_reclutamiento.Image = currentFrame.ToBitmap();

                        labelCara = labelCara + 1;
                        label_caras_reclutamiento.Text = "" + labelCara;

                        if (muestra == 5)
                        {
                            MessageBox.Show("Fin del reclutamiento, haga click en Siguiente para comenzar la VISITA 1");
                            button_huella.Enabled = false;
                        }

                        timer_cara_reclutamiento.Stop();
                        timer_cara_reclutamiento.Enabled = false;
                        capture.Dispose();
                    }
                }
            }    
        }



        private void button_final_reclutamiento_Click(object sender, EventArgs e)
        {
            //COMPROBAR QUE TENEMOS TODAS LAS CARAS, SI NO, AVISAR!
            //DESHABILITAR LA CÁMARA   

            string[] caras = Directory.GetFiles(dirCaras, id + "*").Select(Path.GetFileName).ToArray();
            string[] huellas = Directory.GetFiles(dirHuellas, id + "*").Select(Path.GetFileName).ToArray();
            
            if (caras.Length < 5)
            {
                int faltan = 5 - caras.Length;
                MessageBox.Show("FALTAN " + faltan + " CARAS POR RECLUTAR");
                return;
            }

            if (huellas.Length < 5)
            {
                int faltan = 5 - huellas.Length;
                MessageBox.Show("FALTAN " + faltan + " HUELLAS POR RECLUTAR");
                return;
            }

            axAxisMediaControl_R.Stop();
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
                    if (linea.Contains("_" + nombre + "_") || linea.Contains(dni)) {
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

            nuevoID = "" + numAnterior;
            nuevoID = nuevoID.PadLeft(3, '0');

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

        public Bitmap capturaHuella()
        {            
            int imageWidth, imageHeight;
            byte[] imageArray = null;
            //Bitmap bitmapHuella = null;


            unsafe
            {
                byte* capturedImage = stackalloc byte[200000];
                int codigoError = 0;
                int codigoInit = 0;

                try
                {
                    codigoInit = EikonTouchClass.Init();
                    if (codigoInit != 0)
                    {

                        MessageBox.Show("Error inicializando el sensor de huella");
                        log("Error inicializando el sensor de huella");
                        return null;
                    }

                    codigoInit = EikonTouchClass.Open();
                    codigoError = EikonTouchClass.CaptureImage(10000, &imageWidth, &imageHeight, capturedImage);
                    codigoError = EikonTouchClass.Terminate();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Excepción capturando la huella" + e.ToString());
                    log("Excepción capturando la huella");
                    return null;
                }

                if (codigoError == 0)
                {
                    imageArray = new byte[imageWidth * imageHeight];
                    for (int i = 0; i < imageWidth * imageHeight; i++)
                    {
                        imageArray[i] = *(capturedImage + i);
                    }
                }
            }
                Bitmap bitmap = new Bitmap(imageWidth, imageHeight);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        int colorval = imageArray[(j * imageWidth) + i];
                        bitmap.SetPixel(i, j, Color.FromArgb(colorval, colorval, colorval));
                    }
                }

            return bitmap;
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
                log("No se puede mostrar el stream de la cámara: " + ex.Message);
            }

            return true;
        }


        /********************/
                        

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

        /********/
        
    }
}
