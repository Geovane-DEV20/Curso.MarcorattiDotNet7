// É considerado o terceiro pilar de programação orientada a objetos
// É invocar métodos da mesma classe  derivada através da classe base em tempo de execução.
//  Permitir que classes forneçam  diferentes implementações de métodos que são chamados com o mesmo nome


var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo()
};
foreach (var figura in figuras)
{
    //Aqui eu estou executando o método da classe derivada a partir da classe base
    figura.Desenhar();
}
Console.ReadKey();  

//classe base
public class Figura
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Classe base");
    }
}

class Circulo : Figura 

{
    public override void Desenhar()
    {
        Console.WriteLine("Classe Circulo");
        base.Desenhar();    
    }

}
class Triangulo : Circulo   

{
    public override void Desenhar()
    {
        Console.WriteLine("Classe Triangulo");
        base.Desenhar(); // fazendo uma chamada da classe base
    }

}