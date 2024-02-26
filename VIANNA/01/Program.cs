internal class Program
{
    private static void Main(string[] args)
    {
        
        /*Faça um programa que imprima o seu nome e sobrenome no formato (Sobrenome, Nome).*/
        Console.WriteLine("Juan Pablo");
        
        /*Sabendo que a instrução Console.WriteLine("") imprime o 
        texto que estiver entre aspas e salta a linha, faça um 
        programa que escreva a inicial de seu nome utilizando 
        sequências de espaços e letras X.*/
        Console.WriteLine("XXXXXXXXXX");
        Console.WriteLine("    XX    ");
        Console.WriteLine("    XX    ");
        Console.WriteLine(" X  XX    ");
        Console.WriteLine(" XXXXX    ");
    
        /*Teste a seguinte instrução: 
        Console.WriteLine("Teste\nde\nquebra\nde\nlinha"); 
        Entendendo que \n faz com que o programa salte uma linha, 
        reescreva o programa feito no exercício 2 de forma que o 
        mesmo utilize somente um comando do tipo 
        Console.WriteLine e um comando Console.ReadKey.*/
        Console.WriteLine("Teste\nde\nquebra\nde\nlinha");
        Console.WriteLine("XXXXXXXXXX\n    XX\n    XX\n X  XX\n XXXXX");
        Console.ReadKey();

    }
}