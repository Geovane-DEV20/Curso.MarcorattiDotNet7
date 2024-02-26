






Dictionary<int , int> dic1 = new Dictionary<int , int>();  
var  dic2 = new Dictionary<int , int>();    
dic1.Add(1, 2); 
dic1.Add(2, 499); 
dic1.Add(3, 200);



var dic3 = new Dictionary<int, int>()
{
    {1,100},
    {2,200},
    {3,300}
};


Console.ReadKey();

try
{
    //dic3.Add(3,300); Aqui no caso ele vai cair no catch porque a chave 3 do dicionario ja foi.

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

var resultado = dic3.TryAdd(3,333); // Aqui ele ja retorna se é verdadeiro ou falso 


if(dic3.ContainsKey(7))// Se nao tem essa setencia
{
    dic3.Add(7, 7000);
}