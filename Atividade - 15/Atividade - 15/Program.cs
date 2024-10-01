Console.WriteLine("Digite um número positivo:");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"Tabuada do {numero} é: ");
for (int i = 1; i <= 10; i ++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");

}

Console.WriteLine("Aperte uma tecla para encerrar o programa");
Console.ReadKey();
