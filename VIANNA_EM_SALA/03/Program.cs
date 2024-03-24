internal class Program
{

    static void Main(string[] args){
        char sexo;
        int idade;
        /*bool certificadoReservista;*/

        Console.Write("Informe o seu sexo (M)asculino ou (F)eminino: ");
        sexo = Convert.ToChar(Console.ReadLine());

        Console.Write("Informe a sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        if ((sexo == 'M' || sexo == 'F') && idade >= 18)
        {
            Console.WriteLine("Certificado de reservista ");
        }else
        {
            Console.WriteLine("Certificado de reservista não foi gerado");
        }

        /*certificadoReservista = sexo == 'M' && idade >= 18;
        
        if (certificadoReservista)
        {
            Console.WriteLine("Certificado de reservista ");
        }
        
        */
    }

}