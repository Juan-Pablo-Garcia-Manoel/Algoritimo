internal class Program
{
    private static void Main(string[] args)
    {
        int[] idade = new int[2];
        leIdade(idade);
        imprimeVetor(idade);
    }

    static void leIdade(int[] idade){
        
        string mensagem = "Informe a sua idade: ";

        for (int i = 0; i < idade.Length; i++)
        {
            Mensagem(mensagem);    
            idade[i] = Convert.ToInt32(Console.ReadLine());
        }
        
    }

    static void Mensagem(string texto){
        Console.Write("{0}",texto);
    }

    static void imprimeVetor(int[] idade){
        for (int i = 0; i < idade.Length; i++)
        {
            Console.WriteLine("Idade: {0}",idade[i]);
        }
    }
} 