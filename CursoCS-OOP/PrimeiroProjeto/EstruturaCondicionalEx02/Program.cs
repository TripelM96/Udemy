namespace EstruturaCondicionalEx02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira um número");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");
            Console.ReadKey();
        }
    }
}
