internal class Program{
    /*
        Elaborar um algoritmo para ler o código
        de um produto e informar a sua origem:
        a) Código do produto entre 1 e 20: Europa
        b) Código do produto entre 21 e 40: Ásia
        c) Código do produto entre 41 e 60: América
        d) Código do produto entre 61 e 80: África
        e) Código do produto maior que 80: Paraguai
    */

    private static void Main(string[] Args){
        int codigoProduto;

        Console.Write("Informe o código do produto: ");
        codigoProduto = Convert.ToInt32(Console.ReadLine());

        if(codigoProduto >= 1 && codigoProduto <= 20){
            Console.WriteLine("Europa");
        }else if(codigoProduto >= 21 && codigoProduto <= 40){
            Console.WriteLine("Ásia");
        }else if(codigoProduto >= 41 && codigoProduto <= 60){
            Console.WriteLine("América");
        }else if(codigoProduto >= 61 && codigoProduto <= 80){
            Console.WriteLine("África");
        }else{
            Console.WriteLine("Paraguai");
        }
    }
}