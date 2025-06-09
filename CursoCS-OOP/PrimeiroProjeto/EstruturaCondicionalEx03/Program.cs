
using System.Globalization;
using System.Numerics;

string[] option = Console.ReadLine().Split(' ');
int code = int.Parse(option[0]);
int quantaty = int.Parse(option[1]);

double total;
if (code == 1)
    total = quantaty * 4.00;

else if (code == 2)
    total = quantaty * 4.50;

else if (code == 3)
    total = quantaty * 5.00;

else if (code == 4)
    total = quantaty * 2.00;

else 
    total = quantaty * 1.50;

Console.WriteLine($"Total:  {total.ToString("F2", CultureInfo.InvariantCulture)}");

Console.ReadKey();





