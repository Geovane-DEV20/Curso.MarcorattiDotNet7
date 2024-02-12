// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//declarando uma coleção do tipo List<t> e criando uma variavel
var lista = new List<string>()
{
    "Geovane", "Fiego", "Hamilton"
};


lista.Insert(2, "bia");

string[] array1 = { "Dina", "Carlos" };
lista.AddRange(array1);
lista.InsertRange(1, array1);


for  (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine( $"{lista[i]}");
}   