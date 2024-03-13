internal class Program
{

    /*
    
    */
    static double desconto(double valor, double descontoProduto){
        double resultado;
        resultado = (valor - (valor * (descontoProduto/100))); 
        return resultado;
    }

    private static void Main(string[] args)
    {
        double valor;
       double descontoProduto;
       double resultado;

       Console.WriteLine("Informe o valor do produto: ");
       valor = Convert.ToDouble(Console.ReadLine());

       Console.WriteLine("Informe a porcentagem de desconto do produto: ");
       descontoProduto = Convert.ToDouble(Console.ReadLine());

       resultado = desconto(valor,descontoProduto);
       Console.WriteLine("Valor descontado: {0}",resultado);
    }
}