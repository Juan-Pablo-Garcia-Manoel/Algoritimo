internal class Program
{
    /*
    Construa um programa que aplique um
    desconto de 25% sobre o preço de um
    produto recebido como entrada e imprima o valor resultante.
    */
    private static void Main(string[] args)
    {
        double valor,desconto;
        Console.Write("Informe o valor do produto: ");
        valor =  Convert.ToDouble(Console.ReadLine());
        desconto = valor - (valor * 0.25);
        Console.WriteLine("O valor do produto com desconto de 25%: {0}",desconto);
    }
}