namespace _00;

class Program
{
    static void Main(string[] args)
    {
        int i, j;
        int[,] matriz = new int[4,5];

        for (i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i,j] = 0;
            }
        }

        for (i = 0; i < 4; i++)
        {
            Console.WriteLine("Linha: {0}: ", i + 1);   
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("") ;
            }
        }

    }
}
