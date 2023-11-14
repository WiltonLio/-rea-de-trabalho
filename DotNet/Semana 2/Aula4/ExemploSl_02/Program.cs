Console.WriteLine("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine(String.IsNullOrWhiteSpace(nome) ? "Nome vazio" : nome);