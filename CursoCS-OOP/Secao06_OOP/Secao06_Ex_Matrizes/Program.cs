
Console.WriteLine("Insira o numero de linhas e colunas que deseja.");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int[,] mat = new int[n, m];

for (int i = 0; i < n; i++)
{
    string[] values = Console.ReadLine().Split();
    for (int j = 0; j < m; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}

Console.WriteLine("Insira o numero deseja obter as coordenadas");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; i++)
    {
        if (mat[i, j] == x)
        {
            Console.WriteLine($"Position {mat[i, j]}");

        }
        if (j > 0)
        {
            Console.WriteLine("Left: " + mat[i, j - 1]);
        }
        if (i > 0)
        {
            Console.WriteLine("Up: " + mat[i - 1, j]);
        }
        if (j < n - 1)
        {
            Console.WriteLine("Right: " + mat[i, j + 1]);
        }
        if (i < m - 1)
        {
            Console.WriteLine("Down: " + mat[i + 1, j]);
        }
    }
}