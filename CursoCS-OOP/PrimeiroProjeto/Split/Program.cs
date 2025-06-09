using System;
using System.Globalization;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o nome compelto");
            string fullName = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa");
            int bedrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o preço do produto");
            double price =double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Escreva o seu último nome, idade e altura (mesma linha)");
            string[] vect = Console.ReadLine().Split(' ');

            string lastName = vect[0];
            int age = int.Parse(vect[1]);
            double height = double.Parse(vect[2], CultureInfo.InvariantCulture);

            Console.WriteLine(fullName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
