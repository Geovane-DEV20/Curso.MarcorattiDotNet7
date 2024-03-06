//é um tipo que representa referencias a mpetodos com uma lista  de parametros
// delegates sao usados para implementar eventos
// 


DelegateCalculadora calcu = new DelegateCalculadora(Calculdadora.Somar);
var resultado = calcu.Invoke(20, 20);


Console.ReadKey();


public delegate int DelegateCalculadora(int x, int y);

public class Calculdadora { 
    public  static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
}


