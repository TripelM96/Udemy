namespace EstruturaCondicionalEx01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva um Número inteiro");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Neagtivo");
            }
            else 
            {
                Console.WriteLine("Positivo");
            }
        }
    }
}
