namespace CalculadoraIMC
{
    public class DadosIMC
    {
        // Variáveis para peso e altura
        public double Peso { get; set; }
        public double Altura { get; set; }

        // Construtor para facilitar inicializar os dados
        public DadosIMC(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }
    }
}
