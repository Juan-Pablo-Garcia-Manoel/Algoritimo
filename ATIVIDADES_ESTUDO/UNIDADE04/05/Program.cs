namespace _05;

class Program
{
    /*
    Desenvolver um algoritmo para ler o número
    do dia da semana e imprimir o seu
    respectivo nome por extenso. Considerar o
    número 1 como domingo, 2 para segunda
    etc. Caso o dia da semana não exista
    (menor do que 1 ou maior do que 7), exibir a
    mensagem “Dia da semana inválido".
    */
    
    static void Main(string[] args)
    {
        int dia;

        Console.Write("Informe o dia da semana entre 1 á 7: ");
        dia = Convert.ToInt32(Console.ReadLine());

        switch(dia){
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-Feira");
                break;
            case 3:
                Console.WriteLine("Terça-Feira");
                break;
            case 4:
                Console.WriteLine("Quarta-Feira");
                break;
            case 5:
                Console.WriteLine("Quinta-Feira");
                break;
            case 6:
                Console.WriteLine("Sexta-Feira");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Dia da semana inválido");
                break;
        }
    }
}
