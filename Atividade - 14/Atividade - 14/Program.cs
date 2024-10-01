int menu;

do
{
    Console.WriteLine("Escolha uma das opções do menu: \n 1.Exibir uma mensagem \n 2.Fazer uma soma \n 3.Sair ");
    menu = int.Parse(Console.ReadLine());

    if (menu == 1)
    {
        Console.WriteLine("Seja Bem Vindo!");
    }
    if (menu == 2)
    {
        try
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {soma}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Por favor, digite números válidos");
        }

    }

    if (menu == 3)
    {
        Console.WriteLine("Aperte qualquer tecla para sair");
        Console.ReadKey();
    }

    if (menu > 3)
    {
        Console.WriteLine("Digite um número válido");
    }
} while (menu == 1 || menu == 2 || menu == 3);