// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Uma interface nao pode ser instanciada diretamente e seus membros abstratos sao implementados por qualquer classe ou struct que implemente a interface.

// Uma classe que implementa uma interface ela é obrigada a implementar todos seus membros(métodos) abstratos

interface IControle
{
    void Desenhar();

    //Aqui no caso como o método já está implementado eu nao preciso implementar na outra classe derivada.
    public void Exibir()
    {
        Console.WriteLine("Exibindo um exemplo");
    }
}
interface IGrafico
{
    void Calcular();  
}
class Demo : IControle, IGrafico
{
    public void Calcular()
    {

    }

    public void Desenhar()
    {

    }

}