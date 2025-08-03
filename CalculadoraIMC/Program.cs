using System;
using CalculadoraIMC;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite sua altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        DadosIMC dados = new DadosIMC(peso, altura);

        double imc = dados.Peso / (dados.Altura * dados.Altura);

        Console.WriteLine($"Seu IMC é: {imc:F2}");

        string classificação = ClassificarIMC(imc);
        Console.WriteLine($"Classificação: {classificação}");
    }

    static string ClassificarIMC(double IMC)
    {
        if (IMC < 18.5)
            return "Baixo peso";
        else if (IMC >= 18.5 && IMC < 25)
            return "Eutrofia (peso normal)";
        else if (IMC >= 25 && IMC < 30)
            return "Sobrepeso";
        else
            return "Obesidade";
    }

}
