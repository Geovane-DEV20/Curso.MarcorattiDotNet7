﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ClasseDerivada cd = new();
cd.VerificaAcesso();
public class ClasseDerivada : ClasseBase
{
    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Protected_Internal_Membro();
        Internal_Membro();
        //Private_Membro();
        Console.WriteLine( "Acesso ao campo private : private_var usando uma propriedade GET");
        int soma = public_var + protected_var + internal_var + Private_var;  
    }
}
public class ClasseBase
{
    //campos
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    private int private_var = 4;
    //propriedades
    public int Private_var // Encapsulamento na orientação a objetos
    {
        get { return private_var; }
        set { private_var = value; }
    }
    public void Public_Membro()
    {
        Console.WriteLine( "ClasseNase - Metodo Public");

    }
    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseNase - Metodo Protectd");

    }
    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseNase - Metodo Internal");

    }
    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseNase - Metodo Protected Internal");

    }

    private void Private_Membro()
    {
        Console.WriteLine("ClasseNase - Private");

    }
}