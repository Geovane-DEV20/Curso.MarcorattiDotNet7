// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

Console.WriteLine("Hello, World!");


// É uma coleção genérica de tamanho varável que funciona com base no principio LIFO
// Aqui basicamente ele está ordenando em uma pinha e após isso está retirando
Stack<string> stack = new Stack<string>();
stack.Push("Segunda");
stack.Push("Terça");
stack.Push("Quarta");
stack.Push("Quinta");

foreach (var item in stack)
{
    Console.WriteLine(item);
}

//Push: Adiciona um elemento ao topo da pilha.
//Pop: Remove o elemento do topo da pilha.
//Peek (ou Top): Retorna o elemento no topo da pilha sem removê-lo.