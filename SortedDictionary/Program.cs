// Ordenação é feita pela chave


SortedDictionary<int, string> brics = new SortedDictionary<int, string>();


//var brics = new SortedDictionary<int, string>();    
brics.Add(30, "Brasil");
brics.Add(20, "Espanha");
brics.Add(10, "Argentina");// é ordenado automaticamente

if (brics.ContainsKey(70))
    Console.WriteLine("Chave já existe");
else
    brics.Add(70, "África do sul");



brics[30] = "Chile"; //atribuindo novo valor a chave 20
