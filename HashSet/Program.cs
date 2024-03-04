

//HashSet nao permite a inclusao de elementos duplicados

var timesSp = new HashSet<string>() {"Santos", "Palmeiras", "Sao Paul" };
var timesRj = new HashSet<string>() {"Vasco", "Flamengo", "Fluminense" };
var timesBa = new HashSet<string>() {"Bahia", "Vitoria", "Juazeiro" };

var timeMundias = new HashSet<string>() { "Santos", "Palmeiras", "Sao Paulo", "Flamengo" };

if (!timesSp.Contains("Corintias"))
    timesSp.Add("Corintias");
    timesSp.Add("Santos");

var resultado = timesBa.Remove("Bahia");

Console.ReadKey();  