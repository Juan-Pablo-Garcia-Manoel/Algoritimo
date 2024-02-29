internal class Program
{
    public static void Main(string[] args){
        
        /*Aula dia 28/02/2024*/
        /*int dividido por int é int, porém int dividido por double é double*/
        /*O codigo é resolvido da () mais internas para as mais externas*/
        /*Int32, String, Double é o verdadeiro nome do tipo de dado e int32, string, double é um apelido devido a bliblioteca dot net framework*/

        /*String nome;*/  string nome;
        /*Int32 idade;*/ int idade;
        /*Double salario;*/ double salario;

        Console.Write("Informe o seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Informe a sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe a seu salário: ");
        salario = Convert.ToInt32(Console.ReadLine());
    
        Console.WriteLine("Olá {0} de {1} anos. Você recebe R${2}.", nome, idade, salario);

        /*https://www.w3schools.com/cs/index.php*/
    }
}