internal class Program
{

    /*
    Faça um programa que lê uma temperatura em
    graus Celsius e apresenta-a convertida em graus
    Fahrenheit. A fórmula de conversão: F ← (9*C+160)/5
    */
    private static void Main(string[] args)
    {
        double C,F;

        Console.Write("Informe a temperatura: ");
        C = Convert.ToDouble(Console.ReadLine());
        F = (9 * C + 160) / 5;

        Console.WriteLine("{0} graus Celsius, equivale á {1} graus Fahrenheit",C,F);

    }
}