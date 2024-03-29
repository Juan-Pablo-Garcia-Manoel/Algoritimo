namespace _06;

class Program
{
    /* ANOTAÇÃO
    
    While utilizado para teste no inicio.
    Flag valor que determina o fim dos dados de entrada.
    Ler fora enquanto não for flag processa, lê o proximo e finaliza.
    Acumulador sempre que for usalo iniciar com 0.
    Lembrar de colocar o final "Resultado ao fim do while".
    Contador usado para contar o número de ocorrências.
    Contador o acrescimo é fixo exemplo contado = contador + 1.
    já acumulador não ele recebe um valor variável.
    soma += num  é a mesma coisa que soma = soma + num, outros tipos abaixo:
    qtde++ ou qtde += 1 ou qtde = qtde + 1.
    COnverter int para double:
    int soma = 0;
    media = Convert.ToDouble(soma)/qtde;
    */

    static void quadradoRepeticao(int num){
        
        /*
            Desenvolva um algoritmo que leia uma sequência de
            números inteiros, calculando e imprimindo o quadrado de
            cada número lido. A sequência deve terminar quando o
            número 0 (zero) for lido.
        */

        int quadrado;

        while(num != 0){
            quadrado = num * num;
            Console.WriteLine("Quadrado de {0}: {1}",num,quadrado);

            Console.Write("Informe um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void acumuladorSomaRepeticao(int num){

        /*
            Desenvolva um algoritmo que leia uma sequência de
            números inteiros, calcule e imprima a soma dos valores
            lidos. A sequência deve terminar quando o número 0 (zero)
            for lido.
        */

        int soma = 0;

        while(num != 0){
            soma = soma + num;
            Console.WriteLine("Soma Parcial: {0}",soma);

            Console.Write("Informe um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Soma final: {0}",soma);
    }

    public static void acumuladorRepeticao(int num){
        /*
            Desenvolva um algoritmo que leia uma sequência de
            números inteiros e imprima a quantidade de valores lidos. A
            sequência deve terminar quando o número 0 (zero) for lido.
        */

        int cont = 0;
        
        while(num != 0){
            cont++
            Console.WriteLine("Soma Parcial: {0}",soma);

            Console.Write("Informe um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Soma final: {0}",soma);

    }


    static void Main(string[] args)
    {
        int num;
        
        Console.Write("Informe um número inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());

        quadradoRepeticao(num);
        acumuladorSomaRepeticao(num);
        acumuladorRepeticao(num);

    }

    /*
    class Program
{
    static void Main(string[] args)
    {
        int num, soma = 0, qtde = 0;
        double media;

        Console.Write("Informe um inteiro (0 para sair): ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            soma += num; //soma = soma + num;
            qtde++; //qtde += 1; //qtde = qtde + 1;
            Console.Write("Informe um inteiro (0 para sair): ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        media = Convert.ToDouble(soma) / qtde;

        Console.WriteLine("Média: {0}", media);
    }
}

    */
}
