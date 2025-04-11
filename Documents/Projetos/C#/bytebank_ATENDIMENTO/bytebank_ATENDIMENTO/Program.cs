
    Console.WriteLine("Bem vindo ao ByteBank, Atendimento");
void TestaArrayInt()
{
    int[] idades = new int[5];

    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;
    for ( int i = 0; i < idades.Length; i++ )
    {
        int idade = idades[i];
        Console.WriteLine($"Índice [{i}] = {idades[i]}");
        acumulador += idade;
    
    }
    int media = acumulador / idades.Length;
    Console.WriteLine($"Media de idades = {media}");
}

//TestaArrayInt();

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i+1} palavra: ");
        arrayDePalavras[i] = Console.ReadLine();

    }

    Console.WriteLine("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {

            Console.WriteLine($"Palavra encontrada = {busca}.");

        }
    }
}
TestaBuscarPalavra();