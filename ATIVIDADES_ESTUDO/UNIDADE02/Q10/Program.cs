internal class Program
{
    /*
    Escreva um programa para efetuar as quatro operações
    matemáticas básicas (adição, subtração, produto e divisão)
    sobre dois valores informados.
    */
    private static void Main(string[] args)
    {
        double n1,n2,soma,subtracao,produto,divisao;
        
        Console.Write("Informe o valor de N1: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor de N2: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        soma = n1 + n2;
        subtracao = n1 - n2;
        produto = n1 * n2;
        divisao = n1 / n2;

        Console.WriteLine("Soma: {0}\nSubtração: {1}\nProduto: {2}\nDivisão: {3}",soma,subtracao,produto,divisao);
    }
}