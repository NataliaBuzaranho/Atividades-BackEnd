const double pi = 3.14159;
double area = 0;
double raio;
double raio2 = 0;


Console.Write("Informe o raio do círculo: ");
raio = Convert.ToInt16(Console.ReadLine());

raio2 = raio * raio;
area = pi * raio2;

Console.WriteLine($"O valor do círculo é {raio}, do PI é {pi} e a área do círculo é {area}");