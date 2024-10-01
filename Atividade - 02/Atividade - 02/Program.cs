int n1;
int n2;
int adicao = 0;
int subtracao = 0;
double multiplicacao = 0;
double divisao = 0;

Console.Write("Digite um número: ");
n1 = Convert.ToInt16(Console.ReadLine());

Console.Write("Digite um segundo número: ");
n2 = Convert.ToInt16(Console.ReadLine());

adicao = n1 + n2;
Console.WriteLine($"A adição dos valores é: {adicao}");

subtracao = n1 - n2;
Console.WriteLine($"A subtração dos valores é: {subtracao}");

multiplicacao = n1 * n2;
Console.WriteLine($"A multiplicação dos valores é: {multiplicacao}");

divisao = n1 / n2;
Console.WriteLine($"A divisão dos valores é: {divisao}");
