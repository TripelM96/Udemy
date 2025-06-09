
using System.ComponentModel;
using Produto_OOP;

Produto p = new Produto();

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
p.Name = Console.ReadLine();
Console.WriteLine("Preço: ");
p.Price = double.Parse(Console.ReadLine());
Console.WriteLine("Quantidade em stock: ");
p.Quantaty = int.Parse(Console.ReadLine());


Console.WriteLine("Dados do produto : " + p);

Console.WriteLine();
Console.WriteLine("Digite o número de produtos a ser adicionados");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados" + p);

Console.WriteLine();
Console.WriteLine("Digite o número de produtos a ser adicionados");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados" + p);


