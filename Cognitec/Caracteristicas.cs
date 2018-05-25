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



namespace PruebaCognitec
{

    public partial class Caracteristicas : Form
    {

        public Configuration cfg;

        public Caracteristicas()
        {
            InitializeComponent();
            // initialisation of configuration
            cfg = new Configuration(@"..\..\License\frsdk.cfg");
        }



        private void rutaCarpeta_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todos los archivos (*.JPG)|*.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                directorio.Text = openFileDialog1.FileName;
            }

        }

        public int principal()
        {
            
            try {

              CumpleISO.ForeColor = Color.Black;

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
              Cognitec.FRsdk.Image img = Jpeg.load(directorio.Text);


              ///////////////////////  número de caras y puntos característicos  ///////////////////////////////////////////////////////            


              // find faces
              Face.Location[] faceLocations = faceFinder.find (img, minrEyeDist, 0.4F, int.MinValue / 2, int.MinValue / 2, int.MaxValue / 2 - 1, int.MaxValue / 2 - 1);
              //numCaras.Text = "number of found faces: " + faceLocations.Length;
                
              if (faceLocations.Length == 0) { return -3; }
              if (faceLocations.Length > 1) { return -4; }


              // print face locations

              //foreach( Face.Location faceLoc in faceLocations) {

              localizacionCara.Text = "Face location: [x= " + faceLocations[0].pos.x + " y= " + faceLocations[0].pos.y + " width= " + faceLocations[0].width + " conf= " + faceLocations[0].confidence + " ]";

              Eyes.Location[] eyesLocations = eyesFinder.find(img, faceLocations[0]);

                  // iterate over eyes locations
                  foreach (Eyes.Location eyesLoc in eyesLocations)
                  {
                      // print eye locations
                      localizacionOjos.Text = "Eye locations: [first x= " + eyesLoc.first.x + " y= " + eyesLoc.first.y + " conf= " + eyesLoc.firstConfidence + " second x= " + eyesLoc.second.x + " second y= " + eyesLoc.second.y + " conf= " + eyesLoc.secondConfidence + "]";
                  }


                    ///////////////////////  características de los ojos  ///////////////////////////////////////////////////////

                // do we have eyes found
                  if (eyesLocations.Length > 0)
                  {

                      // analyze portrait
                      Portrait.Characteristics portraitCharacteristics = portraitAnalyzer.analyze(new AnnotatedImage(img, eyesLocations[0]));

                      portraitCar1.Text = "Left Eye Open: " + portraitCharacteristics.eye0Open();

                      portraitCar2.Text = "Right Eye Open: " + portraitCharacteristics.eye1Open();

                      portraitCar3.Text = "Exposure: " + portraitCharacteristics.exposure();

                      portraitCar4.Text = "Sharpness: " + portraitCharacteristics.sharpness();


                      // test features
                      Feature.Set features = featureTest.assess(portraitCharacteristics);

                      if (features.wearsGlasses())
                          gafas.Text = "Feature test: Person with glasses. " + portraitCharacteristics.glasses();

                      else
                          gafas.Text = "Feature test: Person without glasses. " + portraitCharacteristics.glasses();



                      // test compliance with ISO 19794-5
                      FullFrontal.Compliance compliance = fullFrontalTest.assess(portraitCharacteristics);

                      int i = 0;

                      

                      if (compliance.isCompliant())
                      {
                          
                          CumpleISO.ForeColor = Color.Green;
                          CumpleISO.Text = "cumple la ISO 19794-5";

                          if (!compliance.isBestPractice())
                              CumpleISO.Text = "cumple la ISO 19794-5 estricta";
                          
                      }
                      else
                      {
                          if (!compliance.mouthClosedBestPractice()) 
                          {
                              ISOerr.AppendText("Not enough mouth closed (strict)" + Environment.NewLine);
                              
                              i++;
                          }
                          if (!compliance.isSharp()) 
                          {
                              ISOerr.AppendText("Is not sharp" + Environment.NewLine); 
                              i++;
                          }
                              
                          /* provoca excepción con las imágenes en escala de grises*/
                          if (!compliance.eyesNotRedBestPractice())
                          {
                              ISOerr.AppendText("Red eye pupils" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.noTintedGlasses()){
                              ISOerr.AppendText("Too much tinted glasses" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.eyesGazeFrontalBestPractice()){
                              ISOerr.AppendText("Not enough frontal gaze" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.eyesOpenBestPractice()){
                              ISOerr.AppendText("Not enough open eyes (strict)" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.isLightingUniform()){
                              ISOerr.AppendText("Not uniform lighting" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.isFrontalBestPractice()){
                              ISOerr.AppendText("Face not frontal(strict)" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.isBackgroundUniformBestPractice()){
                              ISOerr.AppendText("Not background uniform" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.noHotSpots()){
                              ISOerr.AppendText("Hot spots" + Environment.NewLine);
                              i++;
                          }

                          /* lanza excepción en imagenes en escala de grises */
                          if (!compliance.hasNaturalSkinColour())
                          {
                              ISOerr.AppendText("Not natural skin colour" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.goodGrayScaleProfile()){
                              ISOerr.AppendText("Bad gray scale profile" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.imageWidthToHeightBestPractice()){
                              ISOerr.AppendText("Out of the best rate of width/heigth" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.resolutionBestPractice()){
                              ISOerr.AppendText("Bad resolution (strict)" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.resolution()){
                              ISOerr.AppendText("Bad resolution" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.lengthOfHeadBestPractice()){
                              ISOerr.AppendText("Out of the best rate of length" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.widthOfHeadBestPractice()){
                              ISOerr.AppendText("Out of the best rate of width" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.onlyOneFaceVisible()){
                              ISOerr.AppendText("More than one face" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.goodVerticalFacePosition()){
                              ISOerr.AppendText("Bad vertical face position" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.horizontallyCenteredFace()){
                              ISOerr.AppendText("Face not centered horizontally" + Environment.NewLine);
                              i++;
                          }

                          if (!compliance.widthOfHead()){
                              ISOerr.AppendText("Bad sizing (Width)" + Environment.NewLine);
                               i++;
                          }

                          if (!compliance.lengthOfHead()){
                              ISOerr.AppendText("Bad sizing (Height)" + Environment.NewLine);
                               i++;
                          }

                          if (!compliance.goodExposure()){
                              ISOerr.AppendText("Bad exposure" + Environment.NewLine);
                               i++;
                          }

                          if (!compliance.isFrontal())
                          {
                              ISOerr.AppendText("Face not frontal" + Environment.NewLine);
                              i++;
                          }

                          CumpleISO.ForeColor = Color.Red;
                          CumpleISO.Text = "NO cumple la ISO 19794-5";
                          
                      }
                  //}
              }
              Refresh();
            }
            catch ( FeatureDisabled) {
              
              return 1;
            }
            catch ( LicenseSignatureMismatch) {
              
              return 1;
            }
            catch ( System.Exception) {
              
              return 1;
            }
            return 0;
        }




        private void Iniciar_Click(object sender, EventArgs e)
        {
            if (directorio.Text != "") 
            {
                ISOerr.Text = "";
                CumpleISO.Text = "";
                
                gafas.Text = "";
                portraitCar1.Text = "";
                portraitCar2.Text = "";
                portraitCar3.Text = "";
                portraitCar4.Text = "";
                localizacionCara.Text = "";
                localizacionOjos.Text = "";
                numCaras.Text = "";
                int resultado = principal();

                if (resultado == -3) { numCaras.Text = "No se ha detectado ninguna cara"; }
                if (resultado == -4) { numCaras.Text = "Se han detectado más de una cara"; }
            }
                           

        }

        private void CargarImagen_Click(object sender, EventArgs e)
        {
            if (directorio.Text != "") 
            {
                ImagenCara.Load(directorio.Text);
                ImagenCara.Refresh();
            }            
        }

        //private void FIRconvert_Click(object sender, EventArgs e)
        //{
        //    if (enrollment() == -1)
        //    {
        //        OkEnroll.Text = "Noo!!";                
        //    }
        //    OkEnroll.Visible = true;           
        //}

        //private void identificationFace_Click(object sender, EventArgs e)
        //{
        //    if (identification() == -1)
        //    {
        //        OkIdent.Text = "Noo!!";
        //    }
        //    OkIdent.Visible = true;
        //}

        private void cambioForm2_Click(object sender, EventArgs e)
        {
            EnrollIdenVerif f2 = new EnrollIdenVerif();
            f2.Show();

        }




    }
}
