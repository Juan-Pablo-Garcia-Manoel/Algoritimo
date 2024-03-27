namespace _04;

class Program
{
    static void Main(string[] args)
    {
        int j, numAlunos;

        double[] notas = new double[100];

        Console.Write("Número de alunos: ");
        numAlunos = Convert.ToInt32(Console.ReadLine());

        for (j = 0; j < numAlunos; j++)
        {
            Console.Write("Nota do {0}. aluno: ",j+1);
            notas[j] = Convert.ToDouble(Console.ReadLine());
        }
        Console.Write("Fim da leitura");
    }
}
