internal class Program
{
    private static void Main(string[] args)
    {
        /*Exemplo*/
        int a;
                float b;
            float c;
        
        a = 0;
        b = (float)2.5;
        c = 8.7F * b;

        //Console.WriteLine(c);

        /*Declarando uma variavel*/
        int idade;
        float peso;
        double altura;
        char sexo;

        /*Info*/
        /*
        * int = 4 bytes
        * float = 4 bytes
        * char = 2 bytes 'v'
        * double =  8 bytes
        */       

        /*Declarando variável em uma declaração*/
        int nomeVariavel = 25;

        /*Operação aritiméticas
        Math.Pow(base,2);
        Math.Sqrt(16);
        Math.Sin(x);
        Math.Cos(x);
        Math.Cos(2*x);
        Math.Sin(x)*Math.Cos(y);
        Math.Abs(-5);*/

        /*Operadores
        
        == igual
        != diferente
        < menor que
        <= menor ou igual a
        > maior
        >= maior ou igual a
        ! negação(Não)
        && conjunção(E)
        || dijunção(Ou)
        
        */

        idade = 25;
        Console.Write("Idade: ");
        Console.WriteLine(idade);

        String nome = "Juan";
        String Sobrenome = "Pablo";
        Console.WriteLine("Nome: {0} {1}",nome,Sobrenome);

        /*
            Prioridade para execução de operações em uma expressão:
            1. Parênteses (dos mais internos para os mais externos);
            2. Expressões aritméticas, seguindo a ordem: funções, multiplicação e divisão, adição e subtração;
            3. Expressões lógicas relacionais: <, <=, ==, >, >= e !=;
            4. Expressões lógicas, seguindo a ordem: negação, conjunção, disjunção; 
            5. Da esquerda para a direita, quando houver indeterminações. Na dúvida, use parênteses em suas expressões.
        */

        /*
            Letura de algum dado
            int nomeVar = Convert.ToInt32(Console.ReadLine());
            float nomeVar = Convert.ToSingle(Console.ReadLine());
            double nomeVar = Convert.ToDouble(Console.ReadLine());     
            string nomeVar = Console.ReadLine();
        */

        /*int x;
        x = 10;
        Console.WriteLine(x);
        Console.Readkey();
        */

    }
}