class Produto
    {
        private int codigo;
        public void setCodigo(int novoCodigo) { codigo = novoCodigo; }
        public int getCodigo() { return codigo; }

        private string descricao;
        public void setDescricao(string novaDescricao) { descricao = novaDescricao; }
        public string getDescricao() { return descricao; }

        private double preco;
        public void setPreco(double novoPreco) { preco = novoPreco; }
        public double getPreco() { return preco; }

        public static double calcularMediaPreco(Produto[] produtos)
        {
            double soma = 0;
            for (int i = 0; i < produtos.Length; i++)
            {
                soma += produtos[i].getPreco();
            }
            return soma / produtos.Length;
        }

        public static void imprimirProdutosAcimaMedia(Produto[] produtos, double mediaPreco)
        {
            Console.WriteLine("Produtos com preço acima da média:");
            for (int i = 0; i < produtos.Length; i++)
            {
                if (produtos[i].getPreco() > mediaPreco)
                {
                    Console.WriteLine(produtos[i].getDescricao());
                }
            }
        }

        public static void imprimirPercentualAbaixoMedia(Produto[] produtos, double mediaPreco)
        {
            int contador = 0;
            for (int i = 0; i < produtos.Length; i++)
            {
                if (produtos[i].getPreco() < mediaPreco)
                {
                    contador++;
                }
            }
            double percentual = ((double)contador / produtos.Length) * 100;
            Console.WriteLine("Percentual de produtos com preço abaixo da média: {0}%", percentual);
        }
    }