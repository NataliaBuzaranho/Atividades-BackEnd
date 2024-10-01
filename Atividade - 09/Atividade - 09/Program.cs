string[] vetDiaSemana = new string[]
{
    "Segunda-feira",
    "Terça-feira",
    "Quarta-feira",
    "Quinta-feira",
    "Sexta-feira",
    "Sábado",
    "Domingo"
};
string[] tarefas = new string[7];

Console.WriteLine($"Insira uma tarefa para cada dia da semana: ");
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"Tarefa para {vetDiaSemana[i]}: ");
    tarefas[i] = Console.ReadLine();
}
for (int i = 0; i < vetDiaSemana.Length; i++)
{
    Console.WriteLine($"Sua tarefa na {vetDiaSemana[i]} é: {tarefas[i]}");
}

Console.Write("Aperte uma tecla para encerrar");
Console.ReadKey();