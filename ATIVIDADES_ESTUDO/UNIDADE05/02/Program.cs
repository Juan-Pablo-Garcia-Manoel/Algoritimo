namespace _02;

class Program
{
    static void Main(string[] args){
        
        int num, soma, cont;
        double media;
        
        soma = 0; // inicializa acumulador
        cont = 0; // inicializa contador
        Console.Write("Digite um numero inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        while( num != 0 )
        {
            soma = soma + num; //atualiza acumulador
            cont++; //atualiza contador
            Console.Write("Digite um numero inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        media = soma / (double)cont;
        Console.WriteLine("\nMedia dos elementos: {0}", media);
    }
}
