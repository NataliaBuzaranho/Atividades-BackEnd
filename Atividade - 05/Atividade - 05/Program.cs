double numdec;
int numint = 0;

Console.Write("Insire um número decimal: ");
numdec = Convert.ToDouble(Console.ReadLine());

numint = Convert.ToInt16(numdec);

Console.WriteLine($"O número {numdec} foi convertido para um número inteiro que é {numint}");
