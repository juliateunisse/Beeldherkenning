using System;
using System.Diagnostics;
using Beeldherkenning3ML.Model;

namespace beeldherkenning3

{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine(" Object is not valid for this category.");
            // Add input data
            var input = new ModelInput();
            input.ImageSource = @"C:\Users\bregj\OneDrive\Bureaublad\5VWO\Informatica\beeldherkenning\auto.jpg";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Debug.WriteLine(result.Prediction);
            Console.WriteLine(result.Prediction);
        }
    }
}

