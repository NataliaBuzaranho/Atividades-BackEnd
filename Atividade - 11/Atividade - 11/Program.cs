try
{
    Console.Write("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    int soma = num1 + num2;
    Console.WriteLine($"O resultado da soma é: {soma}");
} catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, digite números válidos");
}

Console.Write("Aperte uma tecla para encerrar!");
Console.ReadKey();