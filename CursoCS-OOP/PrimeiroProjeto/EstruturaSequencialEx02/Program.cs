using System.Globalization;

namespace EstruturaSequencialEx02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Valor raio circulo");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(r, 2);

            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
