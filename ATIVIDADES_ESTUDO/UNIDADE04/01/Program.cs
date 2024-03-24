internal class Program
{

    static void Main(string[] args){
        int n1,n2;

        Console.Write("Informe o valor de N1: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o valor de N2: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        if(n1 == n2)
            Console.WriteLine("Ambos os números são iguais");
        else
        {
            if (n1 > n2)
            {
                Console.WriteLine("O primeiro número é maior do que o segundo número");
            }else
            {
                 Console.WriteLine("O primeiro número é menor do que o segundo número");
            }
        }
    }

}