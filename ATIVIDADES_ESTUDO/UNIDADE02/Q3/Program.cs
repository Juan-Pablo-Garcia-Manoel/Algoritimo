internal class Program
{
    /*
    Faça um programa que leia os valores dos lados e
    altura de um triângulo, calcule e imprima seu
    perímetro e área.
    */
    private static void Main(string[] args)
    {
        double L1, L2, BASE, altura, perimetro, area;

        Console.Write("Informe o valor do lado L1 do triângulo: ");
        L1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor do lado L2 do triângulo: ");
        L2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor da Base do triângulo: ");
        BASE = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor da altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        perimetro = L1 + L2 + BASE;
        area = (BASE * altura)/2;

        Console.WriteLine("Perímetro: {0} e Área: {1}",perimetro,area);

    }
}