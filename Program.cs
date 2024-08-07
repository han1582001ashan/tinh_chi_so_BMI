using System;
namespace BMI
{
    class Program
    {
        static void Main(string[] arg)
        {
            double weight;
            double height;
            Console.WriteLine("Please enter a height");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a weight");
            weight = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);
            Console.WriteLine("BMI: " + bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine("");
            }
            else if (bmi < 25.0)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi < 30.0)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }
        }
    }
}
