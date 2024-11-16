internal class Program
{
    static void Main(string[] args)
    {
        /*
        Altere o algoritmo anterior para que seja
        informado se o número é divisível por 2 e
        por 3, mas que não seja divisível por 5.
        */
        
            int n1;

            Console.Write("Informe um número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            if(n1 % 2 == 0 && n1 % 3 == 0 && n1 % 5 != 0){
                Console.WriteLine("É divisivel por 2 e por 3 e não por 5");
            }else if(n1 % 2 == 0 && n1 % 5 != 0){
                Console.WriteLine("É divisivel por 2 e não por 3 e não por 5");
            }else if(n1 % 3 == 0 && n1 % 5 != 0){
                Console.WriteLine("É divisivel por 3 e não por 2 e não por 5");
            }else if(n1 % 5 == 0 && n1 % 2 != 0 && n1 % 3 != 0 ){
                Console.WriteLine("É divisivel por 5 e não por 2 e não por 3");
            }else if(n1 % 5 == 0 && n1 % 2 == 0 && n1 % 3 != 0 ){
                Console.WriteLine("É divisivel por 5 e por 2 e não por 3");
            }else if(n1 % 5 == 0 && n1 % 2 != 0 && n1 % 3 == 0){
                Console.WriteLine("É divisivel por 5 e por 3 e não por 2");
            }else{
                Console.WriteLine("Não é divisivel por 2 e por 3 e por 5");
            }
        }
        
        /*int num;
        
        Console.Write("Inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0 && num % 3 == 0 && num % 5 != 0)
        {
            Console.WriteLine("{0} é divisível por 2 e por 3 e não é por 5", num);
        }
        else
        {
            Console.WriteLine("{0} NÃO é divisível por 2 ou não é por 3 ou é por 5", num);
        }*/

    }
}