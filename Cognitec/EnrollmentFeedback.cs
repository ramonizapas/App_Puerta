using System;
using Cognitec.FRsdk;
using Eyes = Cognitec.FRsdk.Eyes;
using Enrollment = Cognitec.FRsdk.Enrollment;
using System.IO;

namespace PruebaCognitec
{

    // Implementation of Enrollment.Feedback

    class EnrollmentFeedback : Enrollment.Feedback
    {
        private String firFilename;

        public EnrollmentFeedback(string firFilename_)
        { firFilename = firFilename_; }

        public void start() { Console.WriteLine("start"); }

        public void processingImage(Image img)
        { Console.WriteLine("processing image[{0}]", img.name()); }

        public void eyesFound(Eyes.Location eyes)
        {
            Console.WriteLine
              ("found eyes at [[first x={0} y={1}] [second x={2} y={3}]]",
                eyes.first.x, eyes.first.y, eyes.second.x, eyes.second.y);
        }

        public void eyesNotFound()
        { Console.WriteLine("eyes not found"); }

        public void sampleQualityTooLow()
        { Console.WriteLine("sample quality too low"); }

        public void sampleQuality(float f)
        { Console.WriteLine("sample quality: {0}", f); }

        public void success(FIR fir)
        {
            //Console.WriteLine
            //  ("successful enrollment, FIR[ filename, id, size] = " +
            //    "[\"{0}\", \"{1}\", {2}]", firFilename, fir.version(), fir.size());

            // write the fir  
            FileStream fs = new FileStream(firFilename, FileMode.Create);
            fir.serialize(fs);
            fs.Close();
        }

        public void failure() { Console.WriteLine("failure"); }

        public void end() { Console.WriteLine("end"); }


    };
}
