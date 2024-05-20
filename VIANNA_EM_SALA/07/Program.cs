namespace _07;

class Program
{
    static void Main(string[] args)
    {
        int i,j;
                                /*3 Linhas e 4 colunas, está matriz possui 12 elementos*/
        int[,] matriz = new int[3,4];
        

        for(i = 0; i < 3; i++){ /*Pecorre todas as colunas*/
            for(j = 0; j < 4; j++){ /*para cada linha*/
                matriz[i,j] = 0; /***/
            }
        }

        Console.Write("Matriz:\n");
        for(i = 0; i < 3; i++){ 
            Console.Write("\nLinha {0}\n",i);
            for(j = 0; j < 4; j++){ 
                Console.Write("{0}\t",matriz[i,j]);
            }
        }

    }
}
