
Console.WriteLine("Jogo de adivinhação");

// Cria classe Random
Random rand = new Random();

// Gera um número aleatório entre 1 a 100
int numeroAleatorio = rand.Next(0, 101);
int chute = 0;
int count = 0;

// Exibe uma mensagem para o usuário
Console.WriteLine("\nAdivinhe um número de 1 a 100 (tem que ser um número inteiro)");

// Loop enquanto o palpite não for igual ao número aleatório
while (chute != numeroAleatorio)
{
    // Solicita ao usuário um palpite
    Console.WriteLine();
    Console.Write("Tente um palpite: ");
    chute = int.Parse(Console.ReadLine());
    count++;

    if (chute < numeroAleatorio)
    {
        Console.WriteLine("O número é maior! Tente novamente.");
    }
    else if (chute > numeroAleatorio)
    {
        Console.WriteLine("O número é menor! Tente novamente.");
    }
}

// Exibe a mensagem de acerto e o número de tentativas
Console.WriteLine($"Você acertou ! O número é {numeroAleatorio}. (total de {count} tentativas)");
