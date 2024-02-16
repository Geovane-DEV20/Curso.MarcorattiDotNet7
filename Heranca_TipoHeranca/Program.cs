// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Classe Base
public class Conta
{
    public int Numero { get; set; }         
    public double Saldo { get; private set; }
    
}

// Classe Derivada
public class ContaPoupanca : Conta
{
    public int JurosMensais { get; set; }
 
}


//Daqui pra baixo será class Hierarquica

public class A
{
    public void Exibir()
    {
        Console.WriteLine("Exbindo mensagem");
    }
}

public class B : A
{
    public void Mostrar()
    {
        Console.WriteLine("Mostrando mensagem");
    }
}


public class C : A
{
    public void Apresentando()
    {
        Console.WriteLine("Apresentando mensagem");
    }
}


//Daqui pra baixo heranca multinivel
public class Um
{
    public void Exibir()
    {
        Console.WriteLine("Exbindo mensagem");
    }
}

public class Dois : Um
{
    public void Mostrar()
    {
        Console.WriteLine("Mostrando mensagem");
    }
}


public class Tres : Dois
{
    public void Apresentando()
    {
        Console.WriteLine("Apresentando mensagem");
    }
}

//Herança Multipla
public class Forma
{
    public void SetLado(int s)
    {
        lado = s;
    }

    protected int lado;

}

interface ICusto
{
    int GetCusto(int area);
}

// A linguagem c# n]ao suporte duas classes derivadas. Neste caso só poderia ser uma classe e uma interface.
public class Quadrado : Forma, ICusto
{
    public int GetArea()
    {
        return (lado * lado);
    }


    public int GetCusto(int area) 
    {
        return area * 10;   
    
    }
}