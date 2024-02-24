// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string a = "Geovane";
string b = "Jose";

int x = 100;
int y = 100;

Console.WriteLine(a.Equals(b));
Console.WriteLine(x.Equals(y));


var pessoa1 = new Pessoas(1, "Ana");
var pessoa2 = new Pessoas(2, "Geovane"); 

// vai retornar false. Porque aí no caso ele possui referencias diferentes
public class Pessoas
{
    public Pessoas(int id, string? nome)
    {
        Id = id;
        Nome = nome;
    }

    public int Id { get; set; }
    public string? Nome { get; set; }
}