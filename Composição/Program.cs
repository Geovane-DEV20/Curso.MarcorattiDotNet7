// A composição é um relacionamento do tipo tem um

// Da mesma forma que a herança a composição permite a reutilização de código


public class Casa
{
    private readonly Telhado _telhado;
    private readonly Alicerce _alicerce;

    public Casa()
    {
        _alicerce = new Alicerce(); 
        _telhado = new Telhado(); 

    }


}

public class Telhado
{

}

public class Alicerce
{

}