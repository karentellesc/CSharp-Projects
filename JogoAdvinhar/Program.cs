using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bem vindo ao Jogo de Advinhação");

        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        int chute = 0;
        int tentativas = 0;

        while (chute != numeroAleatorio)
        {
            Console.WriteLine("Digite seu palpite:");
            chute = Convert.ToInt32(Console.ReadLine());
            tentativas++;

            if (chute < numeroAleatorio)
            {
                Console.WriteLine("Você errou! Tente um número maior:");
            }
            else if (chute > numeroAleatorio)
            {
                Console.WriteLine("Você errou! Tente um número menor:");
            }
            else
            {
                Console.WriteLine("Você acertou!");
                Console.WriteLine($"Número de tentativas: {tentativas}");
            }
        }

    }
}