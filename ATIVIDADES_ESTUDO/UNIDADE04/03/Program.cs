internal class Program
{
    /*
        Altere o algoritmo anterior para que seja
        informado se o número é divisível por 2 e
        por 3 simultaneamente.
    */
    static void Main(string[] args){
        int num;

        Console.Write("Inteiro: ");
        num = COnvert.ToInt32(Console.ReadLine());

        if(num % 2 == 0 && num % 3 == 0){
            Console.WriteLine("{0} é divisivel por 2 e por 3",num);
        }else{
             Console.WriteLine("{0} não é divisivel por 2 e por 3",num);
        }
    }
}