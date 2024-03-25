internal class Program
{
    /*
        Ler um número inteiro e informar se ele é
        divisível por 2.
    */
    static void Main(string[] args){
        int num;

        Console.Write("Inteiro: ");
        num = COnvert.ToInt32(Console.ReadLine());

        if(num % 2 == 0){
            Console.WriteLine("{0} é divisivel por 2 ",num);
        }else{
             Console.WriteLine("{0} não é divisivel por 2" ,num);
        }
    }
}