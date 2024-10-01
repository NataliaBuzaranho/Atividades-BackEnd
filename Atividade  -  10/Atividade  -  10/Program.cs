Console.WriteLine("Escolha um número entre 1 a 12:");
int mesesEstacao = int.Parse(Console.ReadLine());

switch (mesesEstacao)
{
    case 1:
        Console.WriteLine("Mês Janeiro, estação Verão");
        break;
    case 2:
        Console.WriteLine("Mês Fevereiro, estação: Verão");
        break;
    case 3:
        Console.WriteLine("Mês Março, estação: Outono");
        break;
    case 4:
        Console.WriteLine("Mês Abril, estação: Outono");
        break;
    case 5:
        Console.WriteLine("Mês Maio, estação: Outono");
        break;
    case 6:
        Console.WriteLine("Mês Junho, estação: Inverno");
        break;
    case 7:
        Console.WriteLine("Mês Julho, estação: Inverno");
        break;
    case 8:
        Console.WriteLine("Mês Agosto, estação: Inverno");
        break;
    case 9:
        Console.WriteLine("Mês Setembro, estação: Primavera");
        break;
    case 10:
        Console.WriteLine("Mês Outubro, estação: Primavera");
        break;
    case 11:
        Console.WriteLine("Mês Novembro, estação: Primavera");
        break;
    case 12:
        Console.WriteLine("Mês Dezembro, estação: Verão");
        break;
    default:
        Console.WriteLine("Erro: O número escolhido não é um mês");
        Console.WriteLine("Digite uma opção entre 1 e 12!.");
        break;
}

Console.WriteLine("Digite uma tecla para encerrar");
Console.ReadKey();
