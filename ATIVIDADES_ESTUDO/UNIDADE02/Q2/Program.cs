internal class Program
{
    /*
        Faça um programa que lê um valor de salário
        mínimo e o salário de um funcionário. O programa
        deve calcular e imprimir quantos salários mínimos
        esse funcionário ganha.
    */
    
    private static void Main(string[] args)
    {
        double salarioFuncionario, salarioMinimo, qtdSalario;
        salarioMinimo = 1412;

        Console.Write("Informe o salario do funcionário: ");
        salarioFuncionario = Convert.ToDouble(Console.ReadLine());

        qtdSalario = (salarioFuncionario/salarioMinimo);

        Console.WriteLine("O funcionário recebe {0} salario(s) minimo(s).",qtdSalario);

    }
}