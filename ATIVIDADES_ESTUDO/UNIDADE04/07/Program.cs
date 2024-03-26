internal class Program
{
    /*
        Desenvolver um algoritmo para ler o valor
        inteiro da idade de uma pessoa e imprimir
        uma das mensagens: se idade < 13:
        Criança, se 13 ≤ idade < 20: Adolescente,
        se 20 ≤ idade < 60: Adulto e se idade ≥ 60:
        Idoso.
    */
    static void Main(string[] args)
    {
        int idade;

        Console.Write("Informe a sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        if(idade < 13){
            Console.WriteLine("Criança");
        }else if(idade >= 13 && idade < 20){
            Console.WriteLine("Adolescente");
        }else if(idade >= 20 && idade < 60){
            Console.WriteLine("Adulto");
        }else{
            Console.WriteLine("Idoso");
        }

        /*
        Está atividade também pode ser feita como abaixo, retirando o && pois o else if entende que a condição anterior não foi valida e os valores são continuos: 
        
        int idade;

        Console.Write("Informe a sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        if(idade < 13){
            Console.WriteLine("Criança");
        }else if(idade < 20){
            Console.WriteLine("Adolescente");
        }else if(idade < 60){
            Console.WriteLine("Adulto");
        }else{
            Console.WriteLine("Idoso");
        }

        */
        
    }
}
