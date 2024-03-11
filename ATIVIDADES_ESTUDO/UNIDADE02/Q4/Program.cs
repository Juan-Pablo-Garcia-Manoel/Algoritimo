internal class Program
{
    /*
    Faça um programa que leia um número inteiro
    e imprima o seu antecessor e sucessor.
    */
    private static void Main(string[] args)
    {
        int n;
        Console.Write("Informe um número inteiro: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Antecessor de N: {0} e Sucessor de N: {1}",n-=1,n+=2);
    }
}