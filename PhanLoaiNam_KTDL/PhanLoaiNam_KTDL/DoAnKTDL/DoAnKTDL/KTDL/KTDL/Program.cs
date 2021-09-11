using System;
using KTDL;

namespace KTDL
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelBuilder.CreateModel();
            ModelInput sampleData = new ModelInput()
            {
                Cap_shape = @"x",
                Cap_surface = @"s",
                Cap_color = @"n",
                Bruises = @"t",
                Odor = @"p",
                Gill_attachment = @"f",
                Gill_spacing = @"c",
                Gill_size = @"n",
                Gill_color = @"k",
                Stalk_shape = @"e",
                Stalk_root = @"e",
                Stalk_surface_above_ring = @"s",
                Stalk_surface_below_ring = @"s",
                Stalk_color_above_ring = @"w",
                Stalk_color_below_ring = @"w",
                Veil_type = @"p",
                Veil_color = @"w",
                Ring_number = @"o",
                Ring_type = @"p",
                Spore_print_color = @"k",
                Population = @"s",
                Habitat = @"u",
            };
            var kq = ConsumeModel.Predict(sampleData);
            // Make a single prediction on the sample data and print results
            //var predictionResult = ConsumeModel.Predict(sampleData);

            //Console.WriteLine("Using model to make single prediction -- Comparing actual Class with predicted Class from sample data...\n\n");
            //Console.WriteLine($"Cap_shape: {sampleData.Cap_shape}");
            //Console.WriteLine($"Cap_surface: {sampleData.Cap_surface}");
            //Console.WriteLine($"Cap_color: {sampleData.Cap_color}");
            //Console.WriteLine($"Bruises: {sampleData.Bruises}");
            //Console.WriteLine($"Odor: {sampleData.Odor}");
            //Console.WriteLine($"Gill_attachment: {sampleData.Gill_attachment}");
            //Console.WriteLine($"Gill_spacing: {sampleData.Gill_spacing}");
            //Console.WriteLine($"Gill_size: {sampleData.Gill_size}");
            //Console.WriteLine($"Gill_color: {sampleData.Gill_color}");
            //Console.WriteLine($"Stalk_shape: {sampleData.Stalk_shape}");
            //Console.WriteLine($"Stalk_root: {sampleData.Stalk_root}");
            //Console.WriteLine($"Stalk_surface_above_ring: {sampleData.Stalk_surface_above_ring}");
            //Console.WriteLine($"Stalk_surface_below_ring: {sampleData.Stalk_surface_below_ring}");
            //Console.WriteLine($"Stalk_color_above_ring: {sampleData.Stalk_color_above_ring}");
            //Console.WriteLine($"Stalk_color_below_ring: {sampleData.Stalk_color_below_ring}");
            //Console.WriteLine($"Veil_type: {sampleData.Veil_type}");
            //Console.WriteLine($"Veil_color: {sampleData.Veil_color}");
            //Console.WriteLine($"Ring_number: {sampleData.Ring_number}");
            //Console.WriteLine($"Ring_type: {sampleData.Ring_type}");
            //Console.WriteLine($"Spore_print_color: {sampleData.Spore_print_color}");
            //Console.WriteLine($"Population: {sampleData.Population}");
            //Console.WriteLine($"Habitat: {sampleData.Habitat}");
            Console.WriteLine($"\n\nPredicted Class value {kq.Prediction} \nPredicted Class scores: [{String.Join(",", kq.Score)}]\n\n");
            //Console.WriteLine("=============== End of process, hit any key to finish ===============");
            //Console.ReadKey();
        }
    }
}
