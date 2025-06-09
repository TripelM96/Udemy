
using System.Threading.Channels;

//double[,] mat = new double[2, 3];

//Console.WriteLine(mat.Length); // quantos elementos a mtriz tem no total 

//Console.WriteLine(mat.Rank); // quantidade de linhas 

//Console.WriteLine(mat.GetLength(0)); //1 Dimensao

//Console.WriteLine(mat.GetLength(1)); //2 Dimensao

/////////////////////////////////////////////////////////////
///

int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];


// 1. Lê a matriz, percorre a matriz
for (int i = 0; i < n; i++)
{
    string[] values = Console.ReadLine().Split();

    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}

// 2. Lê a diagonal 
Console.WriteLine("Main diagonal:");
for (int i = 0; i < n; i++)
{
    Console.Write(mat[i, i] + "");
}
Console.WriteLine();

// 3. Contar quantos numeros negativos existem
int count = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] < 0)
        {
            count++;
        }
    }
}
Console.WriteLine("Neagtive numbers: " + count);
