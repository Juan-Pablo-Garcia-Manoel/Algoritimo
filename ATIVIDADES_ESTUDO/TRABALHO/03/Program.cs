namespace _03;

class Program
{
    static void Main(string[] args)
    {
        /*
        Faça um programa que leia um vetor de produtos. Um produto possui
        um código (inteiro), uma descrição e um preço. O programa deve:
        a) Calcular a média dos preços dos produtos do vetor;
        b) Imprimir as descrições dos produtos com preço acima da média calculada
        em (a).
        c) Imprimir o percentual de produtos com preços abaixo da média calculada
        em (a).
        */
        
            Produto[] produtos = new Produto[3];
            cadastroProduto(produtos);
            double mediaPreco = Produto.calcularMediaPreco(produtos);
            Produto.imprimirProdutosAcimaMedia(produtos, mediaPreco);
            Produto.imprimirPercentualAbaixoMedia(produtos, mediaPreco);
        }

        static void cadastroProduto(Produto[] produtos)
        {
            for (int i = 0; i < produtos.Length; i++)
            {
                produtos[i] = new Produto();

                Console.Write("Informe o código do produto: ");
                produtos[i].setCodigo(Convert.ToInt32(Console.ReadLine()));

                Console.Write("Informe a descrição do produto: ");
                produtos[i].setDescricao(Console.ReadLine());

                Console.Write("Informe o preço do produto: ");
                produtos[i].setPreco(Convert.ToDouble(Console.ReadLine()));
            }
        }
}

