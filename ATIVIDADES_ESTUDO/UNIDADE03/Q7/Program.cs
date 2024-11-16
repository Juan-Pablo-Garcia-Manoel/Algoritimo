internal class Program
{
    /*Faça o teste de mesa do programa abaixo:*/
    private static void Main(string[] args)
    {
        int x = 2, y = 5;
        Console.Write("{0} {1} {2}",x,y, Calculo(x,y));
    }
    static int Calculo (int p, int q)
    {
        p = p * 10;
        q = q + 10;
        return(p + q); 
    }
}