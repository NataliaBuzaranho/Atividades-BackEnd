double tempcelsius;
double multiplicacao = 0;
double soma = 0;

Console.Write("Informe a temperatura em Celsius: ");
tempcelsius = Convert.ToInt16(Console.ReadLine());

multiplicacao = (tempcelsius * 1.8);

soma = (multiplicacao + 32);

Console.WriteLine($"A temperatura em Fahrenheit é {soma}");