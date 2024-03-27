namespace _05;

class Program
{
    const int NUM_VOTOS = 25;
    const int NUM_CANDIDATOS = 5;
    static void Main(string[] args)
    {
        int i, cand;
        int[] contador = new int[NUM_CANDIDATOS];

        for (i = 0; i < NUM_VOTOS; i++)
        {
            Console.Write("Entre com {0} o voto:",i);
            cand = Convert.ToInt32(Console.ReadLine());
            contador[cand]++;
        }

        for (i = 0; i < NUM_CANDIDATOS; i++)
        {
            Console.Write("\nCandidato {0}: {1} votos", i, contador[i]);    
        }

    }
}
