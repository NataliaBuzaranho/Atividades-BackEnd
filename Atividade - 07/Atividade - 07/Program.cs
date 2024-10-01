double n1;
double n2;
double n3;
double soma = 0;
double divisao = 3;

Console.Write("Informe a primeira nota: ");
n1 = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe a segunda nota: ");
n2 = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe a terceira nota: ");
n3 = Convert.ToInt16(Console.ReadLine());

soma = n1 + n2 + n3;

divisao = soma / 3;

Console.WriteLine($"A média aritmética das três notas é: {divisao}");
