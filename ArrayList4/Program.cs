// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
var lista = new ArrayList() { "Maria", 5, true, "", null, 1.1, "Zé", DateTime.Now };


var res1 = lista.Contains(5);
var res2 = lista.Contains("Maria");

var nomes = new ArrayList() { "Maria", "Geovane", "Diego", "Gabriel", "Tiago"};
lista.Sort(); //vair ordenar os elementos
lista.Clear(); //Remove todos os elementos

