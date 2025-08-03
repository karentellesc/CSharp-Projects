using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite sua senha de 8 caracteres:");
        string senha = Console.ReadLine();
        int tamanho = senha.Length;

        if (senha.Length < 8)
        {
            Console.WriteLine("Senha muito pequena.");
        }

        bool temMaiuscula = false;
        bool temMinuscula = false;
        bool temNumero = false;
        bool temCaracter = false;

        foreach (char c in senha)
        {
            if (char.IsUpper(c))
                temMaiuscula = true;
            else if (char.IsLower(c))
                temMinuscula = true;
            else if (char.IsDigit(c))
                temNumero = true;
            else if ("!@#$%^&*()-_=+[]{}|;:'\",.<>?/\\`~".Contains(c)) ;
            temCaracter = true;
        }

        if (!temMaiuscula)
            Console.WriteLine("A senha precisa ter pelo menos uma letra maiúscula.");
        if (!temMinuscula)
            Console.WriteLine("A senha precisa ter pelo menos uma letra minúscula.");
        if (!temNumero)
            Console.WriteLine("A senha precisa ter pelo menos um número.");
        if (!temCaracter)
            Console.WriteLine("A senha precisa ter pelo menos um caracter especial.");

        if (senha.Length >= 8 && temMaiuscula && temMinuscula && temNumero && temCaracter)
        {
            Console.WriteLine("Senha válida.");
        }

    }
}