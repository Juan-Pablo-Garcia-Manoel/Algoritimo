internal class Program
{
    /*
    Elaborar um programa que calcule e apresente o volume de uma
    caixa retangular, por meio da fórmula:
    volume = comprimento*largura*altura.
    */
    private static void Main(string[] args)
    {
        double volume,comprimento,largura,altura;

        Console.Write("Informe o valor do comprimento: ");
        comprimento = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor da largura: ");
        largura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor da altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        volume = comprimento*largura*altura;

        Console.WriteLine("O volume desta caixa retângular equivale á {0}",volume);
    }
}