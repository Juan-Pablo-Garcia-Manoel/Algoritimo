internal class Program
{
    /*
    Fazer um programa para ler o valor de um produto (em
    reais) e o valor de um desconto (em reais). Imprima o
    valor do produto após a aplicação do desconto. Dica:
    declare duas variáveis: valorProduto e valorDesconto,
    sendo ambas do tipo double.
    */
    private static void Main(string[] args)
    {
        double valorProduto,valorDesconto;
        
        Console.Write("Informe o valor do produto em reais: ");
        valorProduto = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor de desconto do produto em reais: ");
        valorDesconto = Convert.ToDouble(Console.ReadLine());
        
        valorProduto = valorProduto - valorDesconto;

        Console.WriteLine("Valor do produto após desconto: R$ {0}",valorProduto);
    }
}