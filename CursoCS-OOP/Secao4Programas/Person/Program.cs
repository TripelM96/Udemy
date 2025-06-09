
using Person;

Human person1, person2;
person1 = new Human();
person2 = new Human();

Console.WriteLine("Dados da segunda pessoa");
Console.Write("Nome: ");
person1.Name = Console.ReadLine();
Console.Write("Idade: ");
person1.Age = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa");
Console.Write("Nome: ");
person2.Name = Console.ReadLine();
Console.Write("Idade: ");
person2.Age = int.Parse(Console.ReadLine());

if (person1.Age > person2.Age)
    Console.WriteLine($"Pessoa mais velha é: {person1.Name}");
else
    Console.WriteLine($"Pessoa mais velha é: {person2.Name}");
Console.ReadKey();
