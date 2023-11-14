#region ExemploSl_07
    List<int> numeros = new List<int>();
    numeros.Add(1);
    numeros.Add(2);
    numeros.Add(3);
    numeros.Add(4);
    numeros.Add(5);

    Console.WriteLine("Lista de numeros inteiros");
    foreach (int numero in numeros)
    {
        Console.WriteLine(numero);
    }

    List<String> nomes = new List<String>();
    nomes.Add("João");
    nomes.Add("Maria");
    nomes.Add("Pedro");
    nomes.Add("Ana");
    nomes.Add("Lucas");

    Console.WriteLine($"Lista de strings");
    foreach (String nome in nomes)
    {
        Console.WriteLine(nome);
    }
    
    List<List<String>> nomes2 = new List<List<String>>();
    nomes2.Add(new List<String>(){"João", "Maria"});
    nomes2.Add(new List<String>(){"Pedro", "Ana", "Lucas"});
    foreach(List<String> nome in nomes2)
    {
        foreach(String nome2 in nome)
        {
            Console.WriteLine(nome);
            
        }
    }
#endregion

#region Lista de datas
    
    DateTime dataexemplo = DateTime.Now;
    Console.WriteLine(dataexemplo);  
    Console.WriteLine(dataexemplo.ToString("dd/MM/yyyy HH:mm:ss"));

#endregion

#region Exercicio
    DateTime data = DateTime.Now;
    Console.WriteLine(data);
    Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss"));

#endregion