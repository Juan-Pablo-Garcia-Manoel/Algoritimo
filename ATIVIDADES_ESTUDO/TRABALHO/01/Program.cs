namespace _01;

class Program
{
    /*
    Questão 1: Faça um procedimento que receba um vetor de funcionários. Cada
    funcionário deve ser um objeto e possuir os atributos código (inteiro), nome (string)
    e ano de contratação (inteiro). O procedimento deve imprimir os dados do(s)
    funcionário(s) com maior tempo de contratação (mais de um funcionário pode ter
    sido contratado no mesmo ano).
    */
    static void Main(string[] args)
    {
        Funcionario[] funcionarios = new Funcionario[3];

        cadastroFuncionario(funcionarios);
        procedimentoFuncionarios(funcionarios);
    }

    static void procedimentoFuncionarios(Funcionario[] funcionarios){
        Console.WriteLine("Funcionários com maior tempo de contratação:");
        
        for (int i = 0; i < funcionarios.Length; i++)
        {
            int primeiro = funcionarios[0].getAnoDeContratacao();

            if(primeiro < funcionarios[i].getAnoDeContratacao()){
                Console.WriteLine("Nome: {0}, Código: {1}, Ano de contratação {2}",funcionarios[i].getNome(), funcionarios[i].getCodigo(), funcionarios[i].getAnoDeContratacao());
            }
        }
    }

    static void cadastroFuncionario(Funcionario[] funcionarios){
        for (int i = 0; i < funcionarios.Length; i++)
        {

                funcionarios[i] = new Funcionario();

                Console.Write("Informe o código do funcionário: ");
                funcionarios[i].setCodigo(Convert.ToInt32(Console.ReadLine()));

                Console.Write("Informe o nome do funcionário: ");
                funcionarios[i].setNome(Console.ReadLine());

                Console.Write("Informe o ano de contratação do funcionário: ");
                funcionarios[i].setAnoDeContratacao(Convert.ToInt32(Console.ReadLine()));
        }
    }

}
