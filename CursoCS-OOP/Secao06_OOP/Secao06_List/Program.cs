
string[] vect = new string[] {"Maria", "Bob", "Alex" };

for (int i = 0; i < vect.Length; i++)
    Console.WriteLine(vect[i]);

Console.WriteLine("----------------------------------");

foreach (string obj in vect)
    Console.WriteLine(obj);


List<string> list = new List<string>();

//List<string> list2 = new List<string> { "Maria", "Alex"};

// 1. Inserir elementos na list
list.Add("Maria"); // Por default o Add adicona ao final da lista.
list.Add("Alex");
list.Add("Bob");
list.Add("Ana");

list.Insert(2, "Marco");
//list.Add(new Product());


foreach (string obj in list)
    Console.WriteLine(obj);

// 2. Tamanho da lista
Console.WriteLine("List count: " + list.Count);

// 3. Encontrar primeiro ou ultimo ELEMENTO da lista que satisfaça um predicado
string s1 = list.Find(x => x[0] == 'A');
Console.WriteLine("First 'A': " + s1);

/*  ////// Consulta Para a primeira letra A com o metodo Teste
string s1 = list.Find(Test);
Console.WriteLine("First 'A': " + s1);
static bool Test(string s)
{
    return s[0] == 'A'; 
}
*/

string s2 = list.FindLast(x => x[0] == 'A');
Console.WriteLine("Last 'A': " + s2);

// 4. Encontrar primeiro ou ultima POSIÇÃO da lista que satisfaça um predicado

int pos1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("Firts position 'A': " + pos1);

int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Last position 'A': " + pos2);

// 5. Filtrar lista com base no predicado

List<string> list2 = list.FindAll(x => x.Length == 5);
Console.WriteLine("----------------------");
foreach (string obj in list2)
    Console.WriteLine(obj);

// 6. Remover elementos da lista

list.Remove("Alex");
Console.WriteLine("----------------------");
foreach (string obj in list)
    Console.WriteLine(obj);

list.RemoveAll(x => x[0] == 'M');
Console.WriteLine("----------------------");
foreach (string obj in list)
    Console.WriteLine(obj);

list.RemoveAt(3);
Console.WriteLine("----------------------");
foreach (string obj in list)
    Console.WriteLine(obj);

list.RemoveRange(2,2);
Console.WriteLine("----------------------");
foreach (string obj in list)
    Console.WriteLine(obj);







