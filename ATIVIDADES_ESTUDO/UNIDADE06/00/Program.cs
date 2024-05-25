namespace _00;

class Program
{
    
    /*
        Criar uma função que receba
        um vetor de números reais e seu tamanho
        e retorne o índice do maior valor contido
        no vetor. Se houver mais de uma
        ocorrência do maior valor, retornar o
        índice do primeiro. Faça um programa
        principal para testar a função.
    */

     static void imprimirVetor(double[] numerosReais){
        for (int i = 0; i < numerosReais.Length; i++)
        {
            Console.Write("{0}\t",numerosReais[i]);
        }
    }

    static double retornoIndice(double[] numerosReais, int tamanho){
        
        double maiorValor = numerosReais[0];
        int indice = 0;

        for(int i = 0; i < tamanho; i++)
        {            
            if(numerosReais[i] > maiorValor){
                maiorValor = numerosReais[i];
                indice = i;
            }
        }

        return indice;
    }

    static void Main(string[] args)
    {
        double[] numerosReais = new double[]{2,9,1,9};
        int tamanho = numerosReais.Length;
        imprimirVetor(numerosReais);
        double maiorIndice = retornoIndice(numerosReais,tamanho);
        Console.WriteLine("O indice do maior valor contido no vetor acima é: {0} ",maiorIndice);
    }
}
