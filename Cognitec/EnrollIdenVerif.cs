using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Cognitec.FRsdk;
using Face = Cognitec.FRsdk.Face;
using Eyes = Cognitec.FRsdk.Eyes;
using Portrait = Cognitec.FRsdk.Portrait;
using FullFrontal = Cognitec.FRsdk.ISO_19794_5.FullFrontal;
using Feature = Cognitec.FRsdk.Portrait.Feature;
using Enrollment = Cognitec.FRsdk.Enrollment;
using Identification = Cognitec.FRsdk.Identification;
using Verification = Cognitec.FRsdk.Verification;
using System.IO;


namespace PruebaCognitec
{
    public partial class EnrollIdenVerif : Form
    {

        public Configuration cfg;
        
        Face.Finder faceFinder;

        public EnrollIdenVerif()
        {
            InitializeComponent();
            // initialisation of configuration
            cfg = new Configuration(@"..\..\License\frsdk.cfg");
            faceFinder = new Face.Finder(cfg);
        }


        public int enrollment(string directorioFIR)
        {
            try
            {

                if (directorio.Text == "") { return -1; }

                Cognitec.FRsdk.Image img = Jpeg.load(directorio.Text);

                Face.Location[] faceLocations = faceFinder.find(img);

                if (faceLocations.Length == 0)
                    return -3;

                if (faceLocations.Length > 1)                 
                    return -4;                


                Sample s = new Sample(img);

                Sample[] enrollmentSamples = new Sample[1] { s };

                // create an enrollment processor
                Enrollment.Processor proc = new Enrollment.Processor(cfg);

                // create the needed interaction instances
                Enrollment.Feedback feedback = new EnrollmentFeedback(directorioFIR + "\\" + nombreFIR.Text + ".fir");

                // do the enrollment
                proc.process(enrollmentSamples, feedback);

                return 1;

            }
            catch (System.Exception)
            {

                return -1;
            }

        }


        public int identification(string directorioFIR)
        {
            try
            {
                Matches.Clear();

                string[] nomFicheros = System.IO.Directory.GetFiles(directorioFIR);

                if (directorioFIR == "") { return -1; }

                Cognitec.FRsdk.Image img = Jpeg.load(directorio.Text);

                Face.Location[] faceLocations = faceFinder.find(img);

                if (faceLocations.Length == 0)
                    return -3;

                if (faceLocations.Length > 1)
                    return -4; 

                Sample s = new Sample(img);

                Sample[] identificationSamples = new Sample[1] { s };


                // build the fir population for identification      
                FIRBuilder firBuilder = new FIRBuilder(cfg);
                Population population = new Population(cfg);

                for (int i = 0; i < nomFicheros.Length; i++)
                {
                    string filename = nomFicheros[i];
                    FileStream fs = new FileStream(filename, FileMode.Open);                                        
                    population.append(firBuilder.build(fs), filename);
                    fs.Close();
                }


                // request Score
                ScoreMappings sm = new ScoreMappings(cfg);
                Score score = sm.requestFAR(0.001f);

                // create a identification processor
                Identification.Processor proc = new Identification.Processor(cfg, population);

                // create the needed interaction instances
                Identification.Feedback feedback = new IdentificationFeedback();

                // do the identification
                proc.process(identificationSamples, score, feedback, 50);


                StreamReader sr = new StreamReader(@"..\..\Matches.txt");

                string linea = "";
                int cuentaBorrar = 0;
                char[] anyof = new char[1];
                anyof[0] = '\\';

                while(true)
                {
                    linea = sr.ReadLine();
                    if (linea == null) { break; }
                    Matches.AppendText(linea.Substring(linea.LastIndexOfAny(anyof) + 1) + Environment.NewLine);
                    cuentaBorrar++;
                }
                   
                sr.Close();
                               
                return 1;
            }
            catch (System.Exception)
            {
                return -1;
            }

        }



        public int verification(string directorioFIR, string nombre)
        {
            try
            {

                if (directorio.Text == "" || directorioFIR == "" || nombre == "") { return -1; }

                string[] nomFicheros = System.IO.Directory.GetFiles(directorioFIR);                

                Cognitec.FRsdk.Image img = Jpeg.load(directorio.Text);

                Face.Location[] faceLocations = faceFinder.find(img);

                if (faceLocations.Length == 0)
                    return -3;

                if (faceLocations.Length > 1)
                    return -4; 

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

                // request Score
                ScoreMappings sm = new ScoreMappings(cfg);
                Score score = sm.requestFAR(0.001f);

                // create a verification processor
                Verification.Processor proc = new Verification.Processor(cfg);

                // create the needed interaction instances
                Verification.Feedback feedback = new VerificationFeedback();

                // do the verification
                proc.process(verificationSamples, fir, score, feedback);

                StreamReader sr = new StreamReader(@"..\..\Verification.txt");

                Resultado.Text = sr.ReadLine();

                sr.Close();
                
            }
            catch (System.Exception)
            {
                return -1;
            }

            return 1;

        }







        private void CargarImagen_Click(object sender, EventArgs e)
        {
            if (directorio.Text != "")
            {
                ImagenCara.Load(directorio.Text);
                ImagenCara.Refresh();
            }
        }

        private void FIRconvert_Click(object sender, EventArgs e)
        {
            int resultado = enrollment(directorioFIR.Text);

            if ( resultado == -1)
            {
                OkEnroll.Text = "Noo!!";
            }

            if (resultado == -3)
            {
                MasDeUnaCara.Text = "No se detecta cara";
                MasDeUnaCara.Visible = true;
                return;
            }

            if (resultado == -4)
            {
                MasDeUnaCara.Text = "Se detecta más de una cara";
                MasDeUnaCara.Visible = true;
                return;
            }

            OkEnroll.Visible = true;
        }

        private void identificationFace_Click(object sender, EventArgs e)
        {
            int resultado = identification(directorioFIR.Text);

            if (resultado == -1)
            {
                OkIdent.Text = "Noo!!";
            }

            if (resultado == -3) 
            {
                MasDeUnaCara.Text = "No se detecta cara";
                MasDeUnaCara.Visible = true;
            }

            if (resultado == -4) 
            {
                MasDeUnaCara.Text = "Se detecta más de una cara";
                MasDeUnaCara.Visible = true;
            }

            OkIdent.Visible = true;
        }


        private void selectDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                directorioFIR.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void rutaCarpeta_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todos los archivos (*.JPG)|*.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                directorio.Text = openFileDialog1.FileName;
            }

        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            int resultado = verification(directorioFIR.Text, nombreId.Text); 

            if ( resultado == -1) 
            {
                Resultado.Text = "No!!";
            }

            if (resultado == -2)
            {
                Resultado.Text = "El usuario no esta en la BBDD";
            }

            if (resultado == -3)
            {
                MasDeUnaCara.Text = "No se detecta cara";
                MasDeUnaCara.Visible = true;
            }

            if (resultado == -4)
            {
                MasDeUnaCara.Text = "Se detecta más de una cara";
                MasDeUnaCara.Visible = true;
            }

            Resultado.Visible = true;

        }


        private void cambioForm1_Click(object sender, EventArgs e)
        {
            Captura f2 = new Captura();
            f2.Show();
        }


    }






    /* Clase auxiliar de identificación */

    // Implementation of Identification.Feedback

    public class IdentificationFeedback : Identification.Feedback
    {   

        public void start() {}

        public void processingImage(Cognitec.FRsdk.Image img){}

        public void eyesFound(Eyes.Location eyes){}

        public void eyesNotFound(){}

        public void sampleQualityTooLow(){}

        public void sampleQuality(float f){}

        public void matches(Match[] matches)
        {
            StreamWriter sr = new StreamWriter(@"..\..\Matches.txt");

            foreach (Match match in matches)
            {                
                sr.WriteLine(match.name + "  ->  " + match.score.value);                                    
            }

            sr.Close();
        }

        public void failure(){}

        public void end(){}
    };



    /* Clase auxiliar de Verificación */

    // Implementation of Verification.Feedback

    //class VerificationFeedback : Verification.Feedback
    //{
    //    public string resultado = "";

    //    public void start() {}

    //    public void processingImage(Cognitec.FRsdk.Image img){}

    //    public void eyesFound(Eyes.Location eyes){}

    //    public void eyesNotFound(){}

    //    public void sampleQualityTooLow(){}

    //    public void sampleQuality(float f){}

    //    public void match(Score s)
    //    {
    //        //s.value();            
    //    }

    //    public void success()
    //    {
    //        resultado = "Éxito";
    //    }

    //    public void failure() 
    //    {
    //        resultado = "Fracaso";
    //    }

    //    public void end() 
    //    {
    //        StreamWriter sr = new StreamWriter(@"..\..\Verification.txt");

    //        sr.WriteLine(resultado);

    //        sr.Close();
    //    }
    //};





}
