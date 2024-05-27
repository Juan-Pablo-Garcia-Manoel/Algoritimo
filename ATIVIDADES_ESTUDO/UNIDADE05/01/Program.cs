namespace _01;

class Program
{       
        /*
        Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e escreve o valor de E.
        E = 1 + 1/2 + 1/3 + ... + 1/N
        */

        int n;
        double e;
        double resultado = 0;

        Console.Write("Digite um número inteiro: ");
        n = Convert.ToInt32(Console.ReadLine());

        int i = 2;
        while(i <= n){
            e = 1 + (1/i);
            resultado += e;
            i++;
        }
        
        Console.WriteLine("Resultado: {0:N2}", resultado);
}
