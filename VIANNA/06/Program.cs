internal class Program
{
    private static void Main(string[] args)
    {
        /*DECLARAÇÃO*/
        int[] idade = new int[2];
        int calculo;
        /*ATRIBUINDO VALORES*/
        idade[0] = 22;
        idade[1] = 25;
        calculo = idade[0] - idade[1];

        /*IMPRIMINDO*/

        Console.WriteLine("{0} e {1} e {2}", idade[0],idade[1],calculo);
    }
} 