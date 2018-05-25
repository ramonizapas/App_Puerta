using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.UI;

using Cognitec.FRsdk;
using Face = Cognitec.FRsdk.Face;
using Eyes = Cognitec.FRsdk.Eyes;
using Portrait = Cognitec.FRsdk.Portrait;
using FullFrontal = Cognitec.FRsdk.ISO_19794_5.FullFrontal;
using Feature = Cognitec.FRsdk.Portrait.Feature;
using Enrollment = Cognitec.FRsdk.Enrollment;
using Identification = Cognitec.FRsdk.Identification;
using Verification = Cognitec.FRsdk.Verification;
using Emgu.CV.Structure;
using System.Threading;
using System.IO;
using Cognitec.FRsdk.Portrait.Feature;
using Cognitec.FRsdk.ISO_19794_5.FullFrontal;
using System.Drawing.Drawing2D;


namespace PruebaCognitec
{
    public partial class Captura : Form
    {

        public Configuration cfg;
        Capture capture;

        int resultadoMasivo;

        public Set s;

        int contador;
        int contadorMasivo;
        int resultadoFinal;

        public Captura()
        {
            capture = new Capture();
            cfg = new Configuration(@"License\frsdk.cfg");
                        
            capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 720);      //720
            capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 500);       //500
            InitializeComponent();
            //capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_CONVERT_RGB, 0);

            resultadoMasivo = 0;
            contador = 0;
            contadorMasivo = 0;
            resultadoFinal = 0;
            
        }

        public void capturar()
        {
            ImageViewer viewer = new ImageViewer(); //create an image viewer
            //Capture capture = new Capture();

            //capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 640);
            //capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 420);


            //Application.Idle += new EventHandler(delegate(object sender, EventArgs e)
            //{  //run this until application closed (close button click on image viewer)
            //    viewer.Image = capture.QueryFrame(); //draw the image obtained from camera
            //});
            ////viewer.ShowDialog(); //show the image viewer

            Image<Emgu.CV.Structure.Bgr, Byte> testImage;

            testImage = capture.QueryFrame();
                        

            System.Drawing.Image m = testImage.ToBitmap();

            pictureBox1.Image = m;

            m.Save(@"..\..\prueba.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }


        public int enrollment(string directorioImagen)
        {
            try
            {
                ResultadoEnroll.Visible = false;

                Cognitec.FRsdk.Image img = Jpeg.load(directorioImagen);

                Sample s = new Sample(img);

                Sample[] enrollmentSamples = new Sample[1] { s };
                                
                Enrollment.Processor proc = new Enrollment.Processor(cfg);
                                
                Enrollment.Feedback feedback = new EnrollmentFeedback(@"..\..\fir\" + nombreMasivo.Text + ".fir");
                                
                proc.process(enrollmentSamples, feedback);

                return 0;

            }
            catch (System.Exception)
            {

                return -1;
            }

        }


        public int verification(string directorioFIR, string nombre, string directorioImg)
        {
            try
            {

                string[] nomFicheros = System.IO.Directory.GetFiles(directorioFIR);

                Cognitec.FRsdk.Image img = Jpeg.load(directorioImg);

                Sample s = new Sample(img);

                Sample[] verificationSamples = new Sample[1] { s };

                FIRBuilder firBuilder = new FIRBuilder(cfg);

                bool OK = false;
                char[] anyof = new char[1];
                anyof[0] = '\\';

                for (int i = 0; i < nomFicheros.Length; i++)
                {
                    if (nomFicheros[i].Substring(nomFicheros[i].LastIndexOfAny(anyof) + 1) == (nombre + ".fir"))
                    {
                        OK = true;
                        break;
                    }

                }

                if (!OK)
                    return -2;      // No existe el nombre

                FileStream fs = new FileStream(directorioFIR + "\\" + nombre + ".fir", System.IO.FileMode.Open);

                FIR fir = firBuilder.build(fs);

                fs.Close();
                                
                ScoreMappings sm = new ScoreMappings(cfg);
                Score score = sm.requestFAR(0.001f);
                                
                Verification.Processor proc = new Verification.Processor(cfg);
                                
                Verification.Feedback feedback = new VerificationFeedback();
                                
                proc.process(verificationSamples, fir, score, feedback);

                StreamReader sr = new StreamReader(@"..\..\Verification.txt");

                string resultado = sr.ReadLine();

                sr.Close();

                if (resultado == "Éxito") { return 1; }
                else return -1;
                

            }
            catch (System.Exception)
            {
                return -1;
            }

        }


        public System.Drawing.Image RotateImage(System.Drawing.Image img, float rotationAngle)
        {
            
            Bitmap bmp = new Bitmap(img.Width , img.Height);
                        
            Graphics gfx = Graphics.FromImage(bmp);
                        
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
                        
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
                        
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        
            gfx.DrawImage(img, new Point(0, 0));
                                                
            gfx.Dispose();
                        
            return bmp;
        }


        public System.Drawing.Image Centrar(System.Drawing.Image im, string directorio)
        {

            //System.Drawing.Image im = System.Drawing.Image.FromFile(directorio);

            float minrEyeDist = 0.1F;

            Face.Finder faceFinder = new Face.Finder(cfg);

            Cognitec.FRsdk.Image imagen = Jpeg.load(directorio);
            
            Face.Location[] faceLocations = faceFinder.find(imagen, minrEyeDist, 0.4F, int.MinValue / 2, int.MinValue / 2, int.MaxValue / 2 - 1, int.MaxValue / 2 - 1);

            Eyes.Finder eyesFinder = new Eyes.Finder(cfg);

            Eyes.Location[] eyesLocations = eyesFinder.find(imagen, faceLocations[0]);

            int recorteZ = (int)faceLocations[0].pos.y;
            int recorteX1 = (int)(faceLocations[0].pos.x - 1.5 * faceLocations[0].width);
            int recorteX2 = (int)eyesLocations[0].first.y - (int)(eyesLocations[0].first.y / 1.1);
            int recorteY = (int)(3 * faceLocations[0].width);

            //Rectangle r = new Rectangle(recorteX1, recorteX2, recorteY, recorteZ);

            

            float posicionX = 0;
            float posicionY = 0;

            // iterate over eyes locations
            foreach (Eyes.Location eyesLoc in eyesLocations)
            {
                posicionY = eyesLoc.first.y;
                posicionX = (eyesLoc.first.x + eyesLoc.second.x) / 2;
            }

            
            Bitmap bmp = new Bitmap(im.Width, im.Height);

            float centroX = im.Width / 2;
            float centroY = im.Height / 2;

            Graphics grfx = Graphics.FromImage(bmp);

            Position position = faceLocations[0].pos;

            Point point = new Point(0, 0);
            Point point2 = new Point(-(im.Width / 2 - recorteY / 2), -(im.Height / 2 - recorteY/2 /*- (int)eyesLocations[0].first.y*/));

            grfx.TranslateTransform(centroX - posicionX, centroY - posicionY);
            
            Rectangle origen = new Rectangle(recorteX1, recorteX2, recorteY, im.Height);

            Region reg = new Region(origen);

            grfx.Clip = reg;

            grfx.DrawImage(im, point); 

            grfx.Dispose();

            Bitmap bmp2 = new Bitmap(recorteY, im.Height - (int)eyesLocations[0].first.y + (int)(1.5 * faceLocations[0].width));
            Graphics grfx2 = Graphics.FromImage(bmp2);
            grfx2.DrawImage(bmp, point2);
            grfx2.Dispose();


            return bmp2;
        }





        public System.Drawing.Image rotateImage(string directorio)
        {

            float minrEyeDist = 0.1F;

            Face.Finder faceFinder = new Face.Finder(cfg);

            Cognitec.FRsdk.Image imagen = Jpeg.load(directorio);

            Face.Location[] faceLocations = faceFinder.find(imagen, minrEyeDist, 0.4F, int.MinValue / 2, int.MinValue / 2, int.MaxValue / 2 - 1, int.MaxValue / 2 - 1);

            float radianes = faceLocations[0].rotationAngle;

            

            Eyes.Finder eyesFinder = new Eyes.Finder(cfg);

            Eyes.Location[] eyesLocations = eyesFinder.find(imagen, faceLocations[0]);


            float grados = 0;


            // iterate over eyes locations
            foreach (Eyes.Location eyesLoc in eyesLocations)
            {
                grados = eyesLoc.first.y - eyesLoc.second.y;
            }

            //float grados = (float)(-radianes * 180 / Math.PI);

            
            System.Drawing.Image im = System.Drawing.Image.FromFile(directorio);

            //System.Drawing.Image imag = Centrar(directorio);

            System.Drawing.Image imag = RotateImage(im, grados);

            return imag;

        }







        public bool isRotate(string directorio) 
        { 
       
            float minrEyeDist = 0.1F;

            Face.Finder faceFinder = new Face.Finder(cfg);

            Eyes.Finder eyesFinder = new Eyes.Finder(cfg);

            Portrait.Analyzer portraitAnalyzer = new Portrait.Analyzer(cfg);

            Feature.Test featureTest = new Feature.Test(cfg);

            FullFrontal.Test fullFrontalTest = new FullFrontal.Test(cfg);

            Cognitec.FRsdk.Image imagen = Jpeg.load(directorio);

            Face.Location[] faceLocations = faceFinder.find(imagen, minrEyeDist, 0.4F, int.MinValue / 2, int.MinValue / 2, int.MaxValue / 2 - 1, int.MaxValue / 2 - 1);

            Eyes.Location[] eyesLocations = eyesFinder.find(imagen, faceLocations[0]);

            
            Portrait.Characteristics portraitCharacteristics = portraitAnalyzer.analyze(new AnnotatedImage(imagen, eyesLocations[0]));


            // test compliance with ISO 19794-5
            FullFrontal.Compliance compliance = fullFrontalTest.assess(portraitCharacteristics);


            if (compliance.isFrontal())
                return true; 

            else
                return false;

            //if (compliance.isFrontalBestPractice()) { resultado += 12; }
        }




        public string analisisResultado(int resultado) 
        {
            if (resultado == -1) { return "No se detecta cara"; }
            if (resultado == -2) { return "Hay más de una cara"; }
            if (resultado == -3) { return "No se detectan ojos"; }
            if (resultado == -4) { return "No esta de frente"; }
            if (resultado == -5) { return "Mala posición vertical"; }
            if (resultado == -6) { return "Mala posición horizontal"; }

            //if (resultado == -7) { return "El ancho de la cabeza no es el adecuado"; }

            if (resultado == -7) { return "Aléjese un poquito por favor"; }
            if (resultado == -8) { return "Acérquese un poquito por favor"; }
            if (resultado == -9) { return "Alto incorrecto"; }
            if (resultado == -10) { return "Mala exposición a la luz"; }
            if (resultado == -11) { return "La resolución no es buena"; }
            if (resultado == -12) { return "El color de la piel no es natural"; }
            if (resultado == -13) { return "La iluminación no es uniforme"; }
            if (resultado == -14) { return "El contorno no es suave"; }
            if (resultado == -15) { return "Hay zonas de brillo"; }
            if (resultado == -16) { return "Abra los ojos un poquito por favor"; }
            if (resultado == -17) { return "Mire un poquito al objetivo por favor"; }
            if (resultado == -18) { return "El fondo no es uniforme"; }
            if (resultado == -19) { return "Cierre un poquito la boca por favor"; }
            if (resultado == -20) { return "Sus gafas son demasiado oscuras"; }
            if (resultado == -21) { return "Ojos rojos"; }

            if (resultado == 0)
            {
                timer1.Enabled = false;
                return "Correcto!!";                
            }

            return "";
        }


        
        public int analizarImagenMasivo(string directorio) 
        {

            float minrEyeDist = 0.1F;

            Face.Finder faceFinder = new Face.Finder(cfg);

            Eyes.Finder eyesFinder = new Eyes.Finder(cfg);


            Portrait.Analyzer portraitAnalyzer = new Portrait.Analyzer(cfg);


            FullFrontal.Test fullFrontalTest = new FullFrontal.Test(cfg);

            Cognitec.FRsdk.Image imagen = Jpeg.load(directorio);

            Face.Location[] faceLocations = faceFinder.find(imagen, minrEyeDist, 0.4F, int.MinValue / 2, int.MinValue / 2, int.MaxValue / 2 - 1, int.MaxValue / 2 - 1);

            if (faceLocations.Length == 0) { return -1; }   //no se detecta cara

            Eyes.Location[] eyesLocations = eyesFinder.find(imagen, faceLocations[0]);
                        
            if (faceLocations.Length > 1) { return -2; }    //se detecta más de una cara
            if (eyesLocations.Length <= 0) { return -3; }   //no se detectan los ojos

            Portrait.Characteristics portraitCharacteristics = portraitAnalyzer.analyze(new AnnotatedImage(imagen, eyesLocations[0]));
            
            // test compliance with ISO 19794-5
            FullFrontal.Compliance compliance = fullFrontalTest.assess(portraitCharacteristics);

            return 0;


        }


        public int analisisCalidad(string directorio) 
        {

            int resultado = 0;

            float minrEyeDist = 0.1F;

            Face.Finder faceFinder = new Face.Finder(cfg);

            Eyes.Finder eyesFinder = new Eyes.Finder(cfg);

            Portrait.Analyzer portraitAnalyzer = new Portrait.Analyzer(cfg);

            Feature.Test featureTest = new Feature.Test(cfg);

            FullFrontal.Test fullFrontalTest = new FullFrontal.Test(cfg);

            Cognitec.FRsdk.Image imagen = Jpeg.load(directorio);

            Face.Location[] faceLocations = faceFinder.find(imagen, minrEyeDist, 0.4F, int.MinValue / 2, int.MinValue / 2, int.MaxValue / 2 - 1, int.MaxValue / 2 - 1);

            Eyes.Location[] eyesLocations = eyesFinder.find(imagen, faceLocations[0]);

            
            Portrait.Characteristics portraitCharacteristics = portraitAnalyzer.analyze(new AnnotatedImage(imagen, eyesLocations[0]));


            // test compliance with ISO 19794-5
            FullFrontal.Compliance compliance = fullFrontalTest.assess(portraitCharacteristics);


            if (compliance.isFrontal()) { resultado += 10; }

            if (compliance.isFrontalBestPractice()) { resultado += 12; }

            if (compliance.goodVerticalFacePosition()) { resultado += 3; }

            if (compliance.horizontallyCenteredFace()) { resultado += 3; }

            if (faceLocations[0].width < 70 && faceLocations[0].width > 60) { resultado += 30; } //demasiado cerca

            if (faceLocations[0].width < 80 && faceLocations[0].width > 50) { resultado += 10; } //demasiado lejos            


            if (compliance.lengthOfHead()) { resultado += 2; }

            if (compliance.goodExposure()) { resultado += 2; }


            if (compliance.hasNaturalSkinColour()) { resultado += 1; }

            if (compliance.isLightingUniform()) { resultado += 1; }

            if (compliance.isSharp()) { resultado += 1; }

            if (compliance.noHotSpots()) { resultado += 1; }

            if (compliance.eyesOpenBestPractice()) { resultado += 1; }

            if (compliance.eyesGazeFrontalBestPractice()) { resultado += 1; }


            if (compliance.mouthClosedBestPractice()) { resultado += 1; }

            if (compliance.noTintedGlasses()) { resultado += 1; }

            if (compliance.eyesNotRedBestPractice()) { resultado += 1; }


            return resultado;

        }





        public int analizarImagen(string directorio) 
        {

            float minrEyeDist = 0.1F;
                        
            Face.Finder faceFinder = new Face.Finder(cfg);
                        
            Eyes.Finder eyesFinder = new Eyes.Finder(cfg);

                        
            Portrait.Analyzer portraitAnalyzer = new Portrait.Analyzer(cfg);

                        
            Feature.Test featureTest = new Feature.Test(cfg);

                        
            FullFrontal.Test fullFrontalTest = new FullFrontal.Test(cfg);

            Cognitec.FRsdk.Image imagen = Jpeg.load(directorio);

            Face.Location[] faceLocations = faceFinder.find(imagen, minrEyeDist, 0.4F, int.MinValue / 2, int.MinValue / 2, int.MaxValue / 2 - 1, int.MaxValue / 2 - 1);

            if (faceLocations.Length == 0) { return -1; }

            Eyes.Location[] eyesLocations = eyesFinder.find(imagen, faceLocations[0]);

            //numCaras.Text = "number of found faces: " + faceLocations.Length;

            
            if (faceLocations.Length > 1) { return -2; }
            if (eyesLocations.Length <= 0) { return -3; }

            

            Portrait.Characteristics portraitCharacteristics = portraitAnalyzer.analyze(new AnnotatedImage(imagen, eyesLocations[0]));


            s = featureTest.assess(portraitCharacteristics);


            // test compliance with ISO 19794-5
            FullFrontal.Compliance compliance = fullFrontalTest.assess(portraitCharacteristics);
            
            //Boundaries b = fullFrontalTest.boundaries();
              
            
            /* Aquí pondremos los parámetros por los que discriminaremos las capturas */


            if (!compliance.isFrontal()) { return -4; }

            if (!compliance.goodVerticalFacePosition()){ return -5; }
            

            if (!compliance.horizontallyCenteredFace()){ return -6; }


            if (faceLocations[0].width > 70){ return -7; }


            if (faceLocations[0].width < 60) { return -8; } 

            //AnchoCabeza.Visible = false;

            if (!compliance.lengthOfHead()){ return -9; }
           

            if (!compliance.goodExposure()){ return -10; }

            //if (!compliance.resolution()) { return -11; }

            if (!compliance.hasNaturalSkinColour()) { return -12; }

            if (!compliance.isLightingUniform()) { return -13; }

            if (!compliance.isSharp()) { return -14; }

            if (!compliance.noHotSpots()) { return -15; }

            if (!compliance.eyesOpenBestPractice()) { return -16; }

            if (!compliance.eyesGazeFrontalBestPractice()) { return -17; }
            

            if (!compliance.mouthClosedBestPractice()) { return -19; }

            if (!compliance.noTintedGlasses()) { return -20; }
            
            if (!compliance.eyesNotRedBestPractice()) { return -21; }

            //if (!compliance.isBackgroundUniformBestPractice()) { return -18; }

            
            return 0;
        
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int resultado = 1;
            System.Drawing.Image imagen;

            ResultadoVerif.Visible = false;
            ResultadoEnroll.Visible = false;

            labelEstado.Visible = true;

            using (Image<Bgr, Byte> nextFrame = capture.QueryFrame())
            {
                imagen = nextFrame.ToBitmap();
                pictureBox1.Image = imagen;

                if (contador == 10)
                {    //Cada 2 segundos.
                    contador = 0;
                    pictureBox1.Image.Save(@"..\..\ImagenesCaras\" + nombreFIR.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

                    resultado = analizarImagen(@"..\..\ImagenesCaras\" + nombreFIR.Text + ".jpg");

                    labelEstado.Text = analisisResultado(resultado);

                    if (resultado == 0)
                    {
                        //timer1.Enabled = false;

                        if ((enrollment(@"..\..\ImagenesCaras\" + nombreFIR.Text + ".jpg") != 0))
                        {
                            ResultadoEnroll.Text = "Éxito";
                            ResultadoEnroll.ForeColor = Color.Red;
                        }
                        else
                        {
                            ResultadoEnroll.Text = "Enroll correcto";
                            ResultadoEnroll.ForeColor = Color.Green;
                        }

                        timer1.Enabled = false;
                        ResultadoEnroll.Visible = true;

                        caracteristicas();

                    }
                }
                                
                contador++;
            }
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            ResultadoVerif.Visible = false;
            ResultadoEnroll.Visible = false;

            int resultado = 1;
            System.Drawing.Image imagen;

            labelEstado.Visible = true;

            using (Image<Bgr, Byte> nextFrame = capture.QueryFrame())
            {
                imagen = nextFrame.ToBitmap();
                pictureBox1.Image = imagen;

                if (contador == 10)
                {    //Cada 2 segundos.
                    contador = 0;

                    pictureBox1.Image.Save(@"..\..\Verificacion\" + nombreId.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

                    resultado = analizarImagen(@"..\..\Verificacion\" + nombreId.Text + ".jpg");

                    labelEstado.Text = analisisResultado(resultado);

                    if (resultado == 0)
                    {

                        //timer1.Enabled = false;
                        timer2.Enabled = false;

                        int res = verification(@"..\..\fir\", nombreId.Text, @"..\..\Verificacion\" + nombreId.Text + ".jpg");

                        
                    }
                }

                contador++;
            }


        }



        private void timer3_Tick(object sender, EventArgs e)
        {

            int resultado = 0;
            string directorioImagen = @"..\..\ImagenesCaras\" + nombreMasivo.Text + ".jpg";
            string directorioTemporal = "";
            
            System.Drawing.Image imagen;

            labelEstado.Visible = true;

            using (Image<Bgr, Byte> nextFrame = capture.QueryFrame())
            {
                imagen = nextFrame.ToBitmap();
                pictureBox1.Image = imagen;

                if (contador == 50)
                {
                    contador = 0;


                    if (radioButtonEnroll.Checked)
                    {
                        directorioTemporal = "\\TemporalMasivo\\";
                    }
                    else 
                    {
                        directorioTemporal = "\\TemporalMasivoV\\";
                    }

                    
                    
                    pictureBox1.Image.Save(@"..\.." + directorioTemporal + nombreMasivo.Text + contadorMasivo.ToString() + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

                    resultado = analizarImagenMasivo(@"..\.." + directorioTemporal + nombreMasivo.Text + contadorMasivo.ToString() + ".jpg");
                    

                    if (resultado == -1) { labelEstado.Text = "No se detecta cara"; }
                    if (resultado == -2) { labelEstado.Text = "Se detecta más de una cara"; }
                    if (resultado == -3) { labelEstado.Text = "No se detectan ojos"; }

                    labelEstado.Refresh();
                    
                    if (resultado == 0)
                    {

                        int res = analisisCalidad(@"..\.." + directorioTemporal + nombreMasivo.Text + contadorMasivo.ToString() + ".jpg");

                        if (res > resultadoMasivo) 
                        { 
                            resultadoMasivo = res;
                            resultadoFinal = contadorMasivo;                            
                        }
                                                
                        contadorMasivo++;
                        numImag.Text = contadorMasivo.ToString();
                        numImag.Visible = true;


                        if (contadorMasivo > 2) 
                        {
                            Thread.Sleep(2000);
                            
                            timer3.Enabled = false;
                            
                            contadorMasivo = 0;
                            resultadoMasivo = 0;
                            labelEstado.Visible = false;

                            if (!isRotate(@"..\.." + directorioTemporal + nombreMasivo.Text + resultadoFinal + ".jpg"))
                            {
                                System.Drawing.Image image = rotateImage(@"..\.." + directorioTemporal + nombreMasivo.Text + resultadoFinal + ".jpg");

                                image.Save(@"..\.." + directorioTemporal + nombreMasivo.Text + "rotada.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

                                Centrar(image, @"..\.." + directorioTemporal + nombreMasivo.Text + "rotada.jpg").Save(@"..\.." + directorioTemporal + nombreMasivo.Text + "rotadaCentrada.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                                
                                if (radioButtonEnroll.Checked)
                                {
                                    if (enrollment(@"..\.." + directorioTemporal + nombreMasivo.Text + "rotadaCentrada.jpg") != 0)
                                    {
                                        ResultadoEnroll.Text = "Enroll incorrecto";
                                        ResultadoEnroll.ForeColor = Color.Red;
                                    }
                                    else
                                    {
                                        ResultadoEnroll.Text = "Enroll correcto";
                                        ResultadoEnroll.ForeColor = Color.Green;
                                    }

                                    System.IO.File.Copy(@"..\.." + directorioTemporal + nombreMasivo.Text + "rotadaCentrada.jpg", directorioImagen);
                                }

                                else 
                                {
                                    if (verification(@"..\..\fir\", nombreMasivo.Text, @"..\.." + directorioTemporal + nombreMasivo.Text + "rotadaCentrada.jpg") != 1)
                                    {
                                        ResultadoEnroll.Text = "Verify incorrecto";
                                        ResultadoEnroll.ForeColor = Color.Red;
                                    }
                                    else
                                    {
                                        ResultadoEnroll.Text = "Verify correcto";
                                        ResultadoEnroll.ForeColor = Color.Green;
                                    }
                                
                                }

                                
                                
                            }
                            else 
                            {
                                System.Drawing.Image image = System.Drawing.Image.FromFile(@"..\.." + directorioTemporal + nombreMasivo.Text + resultadoFinal + ".jpg");


                                Centrar(image, @"..\.." + directorioTemporal + nombreMasivo.Text + resultadoFinal + ".jpg").Save(@"..\.." + directorioTemporal + nombreMasivo.Text + "noRotadaCentrada.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);


                                if (radioButtonEnroll.Checked)
                                {
                                    if (enrollment(@"..\.." + directorioTemporal + nombreMasivo.Text + "noRotadaCentrada.jpg") != 0)
                                    {
                                        ResultadoEnroll.Text = "Enroll incorrecto";
                                        ResultadoEnroll.ForeColor = Color.Red;
                                    }
                                    else
                                    {
                                        ResultadoEnroll.Text = "Enroll correcto";
                                        ResultadoEnroll.ForeColor = Color.Green;
                                    }

                                    System.IO.File.Copy(@"..\.." + directorioTemporal + nombreMasivo.Text + "noRotadaCentrada.jpg", directorioImagen);
                                }

                                else 
                                {
                                    if (verification(@"..\..\fir\", nombreMasivo.Text, @"..\.." + directorioTemporal + nombreMasivo.Text + "noRotadaCentrada.jpg") != 1)
                                    {
                                        ResultadoEnroll.Text = "Verify incorrecto";
                                        ResultadoEnroll.ForeColor = Color.Red;
                                    }
                                    else
                                    {
                                        ResultadoEnroll.Text = "Verify correcto";
                                        ResultadoEnroll.ForeColor = Color.Green;
                                    }
                                
                                }

                                
                            }

                            
                            ResultadoEnroll.Visible = true;

                            pictureBox1.Load(directorioImagen);                            
                        }


                    }
                }

                contador++;
            }

        }











        private void caracteristicas() 
        {
            Ethnicity et = s.ethnicity();
            Gender genero = s.gender();

            bool under26 = s.isBelow26();
            bool under36 = s.isBelow36();
            bool ninho = s.isChild();
            bool ninhopequenho = s.isInfant();
            bool ninhomuypequenho = s.isToddler();

            string etnia = et.ToString();
            string sexo = genero.ToString();

            textBoxCaract.AppendText(etnia + Environment.NewLine);
            textBoxCaract.AppendText(sexo + Environment.NewLine);

            if (!under36)
                textBoxCaract.AppendText("Mayor de 36" + Environment.NewLine);
            else 
            {
                textBoxCaract.AppendText("Menor de 36" + Environment.NewLine);
                
                if (under26)
                    textBoxCaract.AppendText("Menor de 26" + Environment.NewLine);
                else
                    textBoxCaract.AppendText("Mayor de 26" + Environment.NewLine);
            }

            if (ninho)
                textBoxCaract.AppendText("niño" + Environment.NewLine);
            else 
            {
                textBoxCaract.AppendText("no es un niño" + Environment.NewLine);

                if (ninhopequenho)
                    textBoxCaract.AppendText("niño pequeño" + Environment.NewLine);
                else 
                {
                    textBoxCaract.AppendText("no es un niño pequeño" + Environment.NewLine);

                    if (ninhomuypequenho)
                        textBoxCaract.AppendText("niño muy pequeño" + Environment.NewLine);
                    else
                        textBoxCaract.AppendText("no es un niño muy pequeño" + Environment.NewLine);
                }
                            
            }
                
        
        }






        private void Captura_click(object sender, EventArgs e)
        {
            textBoxCaract.Clear();


            if (nombreFIR.Text == "")
            {
                ErrorUsu.Visible = true;
            }

            else 
            {
                ErrorUsu.Visible = false;
                timer1.Enabled = true;
            }

        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            textBoxCaract.Clear();

            if (nombreId.Text == "")
            {
                ErrorUsu.Visible = true;
            }

            else
            {
                ErrorUsu.Visible = false;
                timer2.Enabled = true;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void EnrollMasivoStart_Click(object sender, EventArgs e)
        {
            textBoxCaract.Clear();


            if (nombreMasivo.Text == "")
            {
                ErrorUsu2.Visible = true;
            }

            else
            {
                ErrorUsu2.Visible = false;
                timer3.Enabled = true;
            }
        }

        private void BotonImagenFinal_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"..\..\TemporalMasivo\" + nombreMasivo.Text + resultadoFinal + ".jpg");
        }

        

        
 
        

    }



    class VerificationFeedback : Verification.Feedback
    {
        public string resultado = "";

        public void start() { }

        public void processingImage(Cognitec.FRsdk.Image img) { }

        public void eyesFound(Eyes.Location eyes) { }

        public void eyesNotFound() { }

        public void sampleQualityTooLow() { }

        public void sampleQuality(float f) { }

        public void match(Score s)
        {
            //s.value();            
        }

        public void success()
        {
            resultado = "Éxito";
        }

        public void failure()
        {
            resultado = "Fracaso";
        }

        public void end()
        {
            StreamWriter sr = new StreamWriter(@"..\..\Verification.txt");

            sr.WriteLine(resultado);

            sr.Close();
        }
    };


}
