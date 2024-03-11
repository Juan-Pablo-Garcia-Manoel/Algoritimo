internal class Program
{
    /*
    Imprimir o valor 2.346728 com 1, 2, 3 e 5 casas
    decimais.
    */
    private static void Main(string[] args)
    {
        double valor = 2.346728;
        Console.WriteLine("{0:N1}\n{0:N2}\n{0:N3}\n{0:N5}",valor);
    }
}