internal class Program
{

    static void imprimirSoma(int numero1,int numero2){
        int soma;
        soma = Somar(numero1,numero2);
        Console.WriteLine("Soma: {0}",soma);
    }

    static int Somar(int numero1,int numero2){
        int soma;
        soma = numero1 + numero2;
        return soma;
    }


    static void Main(string[] args){
        
        int num1, num2;
        /*int result;*/
        double celsius,fahrenheit;

        Console.Write("Primeiro número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe a temperatura em Celcius: ");
        celsius = Convert.ToDouble(Console.ReadLine());

        imprimirSoma(num1,num2);
        
        /*Somar(10,25);

        result = Somar(num1,num2);
        Console.WriteLine("Soma: {0}",result);
        */

        fahrenheit = CelsiusFahrenheit(celsius);
        Console.WriteLine("Temperatura em Fahrenheit: {0}",fahrenheit);
        Console.ReadKey();''
    }

    static double CelsiusFahrenheit(double tc){
        double tf;
        tf = 1.8 * tc + 32;
        return tf;
    }
}