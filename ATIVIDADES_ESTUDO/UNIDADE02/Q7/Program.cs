internal class Program
{
    /*
    Fazer um programa para imprimir na primeira linha o
    dia, na segunda linha o mês e na terceira o ano de seu
    nascimento.
    */
    private static void Main(string[] args)
    {
        int dia,mes,ano;
        
        Console.Write("Informe o dia de nascimento: ");
        dia = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o mês de nascimento: ");
        mes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o ano de nascimento: ");
        ano = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1° Linha: {0}\n2° Linha: {1}\n3° Linha: {2}",dia,mes,ano);

        /*
        ANOTAÇÃO

        Há a possibilidade de simplemente colocar para imprimir como abaixo:
        Console.WriteLine("1° Linha: 23\n2° Linha: 12\n3° Linha: 1998",dia,mes,ano);
        */
    }
}