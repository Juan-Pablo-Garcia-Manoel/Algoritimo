namespace _02;

class Program
{
    static void Main(string[] args)
    {
        int i;
        int[] vetor = new int[10];

        /*Atribuindo valores ao meu vetor*/
        for(i = 0; i < 10; i++){
            vetor[i] = 0;
        }

        Console.WriteLine("Elemento     Valor");

        for(i = 0; i < 10; i++){
            Console.WriteLine("{0,8} {1,9}\n", i, vetor[i]);
        }

    }
}
