using System.Globalization;
using System.Security.Cryptography;
using Funcionario;
using System.Globalization;

Human func01, func02;
func01 = new Human();
func02 = new Human();

double Avarage;

Console.WriteLine("Dados d primeiro fuincionário");
Console.Write("Nome: ");
func01.Name = Console.ReadLine();
Console.Write("Salário: ");
func01.Salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


Console.WriteLine("Dados d primeiro fuincionário");
Console.Write("Nome: ");
func02.Name = Console.ReadLine();
Console.Write("Salário: ");
func02.Salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Avarage = (func01.Salary + func02.Salary) / 2;

Console.WriteLine($"O salario medio é: {Avarage}");
Console.ReadKey();