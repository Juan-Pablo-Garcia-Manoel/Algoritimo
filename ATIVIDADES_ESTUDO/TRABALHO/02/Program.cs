namespace _02;

class Program
{
    static void Main(string[] args)
    {
        /*
        Crie um programa para representar uma equipe de 10 atletas. Cada
        atleta deve ser representado por um nome, uma idade, um peso e uma altura. É
        obrigatória a utilização de um vetor de objetos para representar a equipe de atletas.
        Crie um procedimento para preencher o vetor de atletas. Crie um procedimento que
        imprime o(s) nome(s) do(s) atletas mais velhos. Crie um procedimento que imprime
        o(s) nome(s) do(s) atleta(s) de maior IMC. IMC = peso / altura2.
        */

        Atleta[] atletas =  new Atleta[10];
        cadastroAtleta(atletas);
        atletasMaisVelhos(atletas);
        atletaMaiorIMC(atletas);

    }

        static void cadastroAtleta(Atleta[] atletas){
        for (int i = 0; i < atletas.Length; i++)
        {

                atletas[i] = new Atleta();

                Console.Write("Informe o nome do atleta: ");
                atletas[i].setNome(Console.ReadLine());

                Console.Write("Informe a idade do atleta: ");
                atletas[i].setIdade(Convert.ToInt32(Console.ReadLine()));

                Console.Write("Informe o peso do atleta: ");
                atletas[i].setPeso(Convert.ToDouble(Console.ReadLine()));

                Console.Write("Informe a altura do atleta: ");
                atletas[i].setAltura(Convert.ToDouble(Console.ReadLine()));

        }
    }

    static void atletasMaisVelhos(Atleta[] atletas)
        {
            int maxIdade = atletas[0].getIdade();

            for (int i = 1; i < atletas.Length; i++)
            {
                if (atletas[i].getIdade() > maxIdade)
                {
                    maxIdade = atletas[i].getIdade();
                }
            }

            for (int i = 0; i < atletas.Length; i++)
            {
                if (atletas[i].getIdade() == maxIdade)
                {
                    Console.WriteLine("Atleta(s) mais velho(s): {0}", atletas[i].getNome());
                }
            }
        }

        static void atletaMaiorIMC(Atleta[] atletas)
        {
            double maxIMC = 0;
            int indexMaiorIMC = 0;

            for (int i = 0; i < atletas.Length; i++)
            {
                double imc = atletas[i].getPeso() / (atletas[i].getAltura() * atletas[i].getAltura());

                if (imc > maxIMC)
                {
                    maxIMC = imc;
                    indexMaiorIMC = i;
                }
            }

            Console.WriteLine("Atleta com maior IMC: {0} , IMC: {1}", atletas[indexMaiorIMC].getNome(), maxIMC);
        }
}