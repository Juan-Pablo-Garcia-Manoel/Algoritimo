internal class Program
{
    /*
    Elaborar um programa que calcule o índice de massa corporal
    (IMC) de um usuário qualquer, sabendo-se que o IMC é
    determinado pela divisão da massa do indivíduo (em
    quilogramas) pelo quadrado de sua altura (em metros).
    */
    private static void Main(string[] args)
    {
        double imc, altura, peso;

        Console.Write("Informe a sua altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o seu peso: ");
        peso = Convert.ToDouble(Console.ReadLine());

        /*imc = (altura * altura)/peso;*/
        imc = peso / Math.Pow(altura,2);

        Console.WriteLine("IMC: {0:N3}",imc);
    }
}