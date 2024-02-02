// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[,] n = new int[2, 3] { {2, 4 , 3 } , { 3, 6, 8} };
for ( int i = 0;  i < n.GetLength(0);   i++)
{
    for(int j = 0; j < n.GetLength(1); j++)
    {
        Console.WriteLine($"{n[i,j]}");
    }
}