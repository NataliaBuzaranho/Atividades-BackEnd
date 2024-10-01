double salario;
double porcentualaum;
double divisao = 0;
double multiplicacao = 0;
double soma = 0;

Console.Write("Informe seu salario mensal: ");
salario = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o porcentual de aumento: ");
porcentualaum = Convert.ToDouble(Console.ReadLine());

divisao = porcentualaum / 100;

multiplicacao = divisao * salario;

soma = multiplicacao + salario;

Console.WriteLine($"O novo salário é: {soma}");