namespace _03;

class Program
{
    static void Main(string[] args)
    {
        int cont, num;
        cont = 0;
        do{
            Console.Write("Digite o {0} o numero: ", cont);
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quadrado de {0}: {1}", num, num * num);
            cont++;
        }while(cont < 15);

        /*
            int cont;
            cont = 0;
            while (cont < 10){
                Console.WriteLine("{0}",cont);
                cont++; 
            }
        */
    }
}
