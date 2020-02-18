using System;
using ML_labML.Model;

namespace ML_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput
            {
                SentimentText = "That is rude."
            };

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
        }
    }
}
