// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Informe o valor x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor y");
int y = Convert.ToInt32(Console.ReadLine());

try { 

    int z = x / y;
    Console.WriteLine($"{x} / {y} = {z}");

}
catch (Exception ex) {
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex?.StackTrace?.ToString());

}
finally {
    Console.WriteLine("Processamento concluido");
        
        
        }


Console.ReadKey(); 

