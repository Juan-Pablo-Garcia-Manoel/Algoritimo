namespace _06;

class Program
{
    /*
        Fazer um algoritmo para ler dois números e
        um dos símbolos das operações: +, -, * e /.
        Imprimir o resultado da operação efetuada
        sobre os números lidos.
    */
    static void Main(string[] args)
    {
        int num1, num2, resultado;
        char caractere;

        Console.Write("Informe o valor de N1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o valor de N2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe qual operação deseja fazer (*) Multiplicação, (/)Divisão, (+)Soma, (-)Subtração: ");
        caractere = Convert.ToChar(Console.ReadLine());

        if(caractere == '*'){
            resultado = num1 * num2;
            Console.WriteLine("{0}",resultado);
        }else if(caractere == '/'){
            resultado = num1 / num2;
            Console.WriteLine("{0}",resultado);
        }else if(caractere == '+'){
            resultado = num1 + num2;
            Console.WriteLine("{0}",resultado);
        }else if(caractere == '-'){
            resultado = num1 - num2;
            Console.WriteLine("{0}",resultado);
        }else{
            Console.WriteLine("Operação inválida");
        }
    }
}
