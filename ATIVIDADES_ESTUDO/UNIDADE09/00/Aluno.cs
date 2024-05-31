class Aluno{
    public int matricula;
    public string? nome;
    public double[] notas = new double[4];

    public double mediaDasNotas(Aluno aluno){
        double media, soma = 0;

        for (int i = 0; i < aluno.notas.Length; i++)
        {
            soma += aluno.notas[i];
        }

        media = (soma/4);

        return media;
    }

    public void aprovacaoAluno(Aluno aluno){
        if (aluno.mediaDasNotas(aluno) >= 7)
        {
            Console.WriteLine("Aluno {0} está aprovado!", aluno.nome);
        }
        else
        {
            Console.WriteLine("Aluno {0} está reaprovado, por estar abaixo da média!", aluno.nome);
        }
    }
}