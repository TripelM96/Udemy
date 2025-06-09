using System.Globalization;
using Seccao04_Ex02_Funcionario;

Funcionario funcionario = new Funcionario();
Console.Write("Nome: ");
funcionario.Name = Console.ReadLine();

Console.Write("Salário Bruto: ");
funcionario.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Imposto: ");
funcionario.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

funcionario.Taxes();

Console.WriteLine("Funcionário " + funcionario);

Console.Write("Insira a percentagem para aumentar o salário");
double percentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

funcionario.Raise(percentagem);

Console.WriteLine("Dados Atualizados" + funcionario);

Console.ReadKey();

