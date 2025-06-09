using System.Globalization;
using Seccao04_Ex01_Retangulo;

Rectangulo rectangulo = new Rectangulo();

Console.WriteLine("Entre a cumprimento e altura do retângulo");
rectangulo.Cumprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
rectangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Area: {rectangulo.Area()}");
Console.WriteLine($"Perimentro: {rectangulo.Perimetro()}");
Console.WriteLine($"Diagonal: {rectangulo.Diagonal()}");
Console.ReadKey();