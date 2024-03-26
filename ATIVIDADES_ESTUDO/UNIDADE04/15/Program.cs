namespace _15;

class Program
{
    /*
        Elabore um programa que, dada a idade
        de um nadador, classifique-o em uma
        das seguintes categorias:
        • infantil A = 5 – 7 anos
        • infantil B = 8 – 10 anos
        • juvenil A = 11 – 13 anos
        • juvenil B = 14 – 17 anos
        • adulto = 18 – 30 anos
        • sênior = maiores de 30 anos

        OBS: Fazer um procedimento e uma função para resolução. Não fazer no main.
    */

    public static void categoriasProcedimento(int idade){
        if(idade <= 7){
            Console.WriteLine("Infantil A");
        }else if(idade <= 10){
            Console.WriteLine("Infantil B");
        }else if(idade <= 13){
            Console.WriteLine("Juvenil A");
        }else if(idade <= 17){
            Console.WriteLine("Juvenil B");
        }else if(idade <= 30){
            Console.WriteLine("Adulto");
        }else{
            Console.WriteLine("Sênior");
        }
    }

    public static string categoriasFuncao(int idade){
             
       if(idade <= 7){
            return "Infantil A";      
        }else if(idade <= 10){
            return "Infantil B"; 
        }else if(idade <= 13){
            return "Juvenil A";
        }else if(idade <= 17){
            return "Juvenil B";
        }else if(idade <= 30){
            return "Adulto";
        }else{
            return "Sênior";
        }
    }

    private static void Main(string[] args)
    {
        int idade;
        string classificacao;
        
        Console.Write("Informe a idade do nadador:  ");
        idade = Convert.ToInt32(Console.ReadLine());

        //categoriasProcedimento(idade);
        classificacao = categoriasFuncao(idade);
        Console.WriteLine("{0}", classificacao);

    }
}
