namespace _00;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();
        coletaDados(aluno);
        imprimirAluno(aluno);
    }

    static void coletaDados(Aluno aluno){
        Console.Write("Informe a sua matricula: ");
        aluno.matricula = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o nome do aluno: ");
        aluno.nome = Console.ReadLine();

        for (int i = 0; i < aluno.notas.Length; i++)
        {
            Console.Write("Nota{0}: ", i + 1);
            aluno.notas[i] = Convert.ToDouble(Console.ReadLine());
        }
    }

    static void imprimirAluno(Aluno aluno){
        Console.WriteLine("Boletim do aluno {0}:", aluno.nome);

        for (int i = 0; i < aluno.notas.Length; i++)
        {
            Console.WriteLine("Nota {0}: {1}", i + 1, aluno.notas[i]);
        }

        Console.WriteLine("Média das notas: {0}", aluno.mediaDasNotas(aluno));
        aluno.aprovacaoAluno(aluno);

    }
}
