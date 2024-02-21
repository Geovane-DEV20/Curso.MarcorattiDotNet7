// A palavra generics significa nao ser especifico para um dterminado tipo de dados
// Classes, métodos, interfaces eu posso utilizar Generics

Teste teste = new Teste();
int i1 = 10;
int i2 = 10;
teste.Comparar(i1, i2);


string s1 = "10";
string s2 = "10";

teste.Comparar(s1,s2);

Console.ReadKey();
public class ClasseGenerica<T>{

}


//Em struct é como se fosse uma restrição
public class ClasseGeneric<T> where T : struct
{

}

public class Teste
{

    //Aqui ele vai servir para comparar os dados de qualquer tipo, Seja string int float e etc
    public void Comparar<T>(T p1, T p2)
    {
        
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} and p2 {p2} são iguais ? {resultado}");

    }
}