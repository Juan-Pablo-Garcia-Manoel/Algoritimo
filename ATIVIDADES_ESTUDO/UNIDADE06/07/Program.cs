namespace _07;

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

    static int maiorValor(double[] vetor){

        int i, indice = 0;
        double aux = vetor[0];

        for (i = 1; i < vetor.Length; i++)
        {
            if(vetor[i] > aux){ 
                aux = vetor[i];
                indice = i;
            }
        }
        return indice;

    }

    static void Main(string[] args)
    {
        double[] vetor = new double[]{5,1,2,9};
        int resultado;

        resultado = maiorValor(vetor);
        Console.WriteLine("{0}",resultado);
    }

}
