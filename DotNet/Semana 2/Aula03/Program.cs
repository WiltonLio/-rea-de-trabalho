#region ReadLIne exemplos
Console.WriteLine("Escreva seu nome: ");
string? nome = Console.ReadLine();
Console.WriteLine($"Olá, {nome}!");
#endregion

#region Exemplo de foreach
string[] colecao= {"Item1", "Item2", "Item3", "Item4"};

foreach (string item in colecao)
{
    Console.WriteLine(item);
}
#endregion