namespace EstruturaSequencialEx03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva 4 valores inteiros");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());  
            int d = int.Parse(Console.ReadLine());

            double diff = (a * b - c * d);

            Console.WriteLine($"Diferenca = {diff}");
        }
    }
}
