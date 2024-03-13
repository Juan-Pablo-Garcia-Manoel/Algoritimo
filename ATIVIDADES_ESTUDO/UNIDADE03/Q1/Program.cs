internal class Program
{
    /*
        
    */
    static void media(double n1, double n2, double n3){
        double media;
        media = (n1 + n2 + n3)/3.0;
        Console.WriteLine("Média: {0}", media);
    }

    private static void Main(String[] args){
        double n1,n2,n3;
        Console.Write("Informe o valor de n1: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor de n2: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor de n3: ");
        n3 = Convert.ToDouble(Console.ReadLine());
        media(n1,n2,n3);
    }
}