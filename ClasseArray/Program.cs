// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] nomes = { "Geovane", "Marta", "Diego", "Lucas", "Guilherme"};

Console.WriteLine("\n\nExibindo o array original....");
ExibeArray(nomes);

Console.WriteLine("\n\nInvertendo a ordem do array0....");
Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine("Ordenando o array..");
Array.Sort(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nLocalizando o nome no array....");
Console.WriteLine("Informe o nome...");

string nome = Console.ReadLine();
var indice = Array.BinarySearch(nomes, nome);
if(indice >= 0)
{
    Console.WriteLine($"\n{nome} foi encontrado com indice = {indice}");
}
else
{
    Console.WriteLine($"\n{nome} não foi encontrado");
}
static void ExibeArray(string[] numeros)
{
    foreach (string str in numeros)
    {
        Console.Write($"{str}");
    }
}