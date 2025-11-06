using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Notas disponíveis: 20, 50, 100");

        int valor = 0;
        int confirma = 0;

        while (true)
        {
            Console.WriteLine("Digite o valor do saque:");
            valor = int.Parse(Console.ReadLine());

            Console.WriteLine($"Valor do saque é de: {valor}. Confirma? Digite 1 para SIM e 2 para NÃO");
            confirma = int.Parse(Console.ReadLine());

            if (confirma == 2)
            {
                Console.WriteLine("Digite novamente o valor do saque.");
                continue; 
            }

            if (confirma != 1)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue; 
            }


            int notas100 = valor / 100;
            int resto = valor % 100;

            int notas50 = resto / 50;
            resto = resto % 50;

            int notas20 = resto / 20;
            resto = resto % 20;

            
            if (resto != 0)
            {
                Console.WriteLine($"Não foi possível realizar o saque com as notas disponíveis.");
                Console.WriteLine("Digite outro valor.");
                continue;
            }

            Console.WriteLine("Contagem de notas...");
    

            Console.WriteLine("Saque finalizado com sucesso!");
            break;
        }
    }
}