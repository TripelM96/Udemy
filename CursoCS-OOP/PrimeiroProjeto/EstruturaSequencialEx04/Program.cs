using System.Globalization;

namespace EstruturaSequencialEx04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número funcionário");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("\nNúmero de horas trabalhadas");
            double time = double.Parse(Console.ReadLine());

            Console.WriteLine("\nValor que recebe por hora");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double salary = value * time;

            Console.WriteLine($"\nNumber = {id}");
            Console.WriteLine($"Salary = {salary.ToString("F2", CultureInfo.InvariantCulture)}");



        }
    }
}
