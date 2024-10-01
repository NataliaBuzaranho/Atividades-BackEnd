int numeroSecreto;
do
{
    Console.Write("Digite um número: ");
    numeroSecreto = int.Parse(Console.ReadLine());

} while (numeroSecreto != 7);
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Você acertou o número secreto!");
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Programa encerrado!");
Console.ReadKey();
Console.ResetColor();