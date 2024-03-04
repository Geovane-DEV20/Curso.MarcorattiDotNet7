//ira ordenar os numeros

var numeros = new List<int>() { 1,7,8,6,4,2};  

SortedSet<int> conjuntos = new SortedSet<int>(numeros);


foreach (int numero in conjuntos)
{
    Console.WriteLine(numero);
}




Console.ReadKey();