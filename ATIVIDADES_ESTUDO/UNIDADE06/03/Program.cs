namespace _03;

class Program
{
    static void Main(string[] args)
    {
        int j;
        int[] vetor = new int[10];

        for (j = 0; j <= vetor.Length - 1; j++)
        {
            vetor[j] = 2 + 2 * j;
        }

        Console.WriteLine("Elemento     Valor\n");

        for (j = 0; j < vetor.Length; j++)
        {
            Console.WriteLine("{0,8} {1,9}\n", j, vetor[j]);
        }

    }
}
