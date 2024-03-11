internal class Program
{
    /*
    Construa um programa para ler um intervalo
    de tempo em segundos, converter para
    horas, minutos e segundos e imprimir o
    resultado.
    */

    private static void Main(string[] args)
    {
        int horas,segundos,minutos;

        Console.Write("Informe o intervalo de tempo em segundos: ");
        segundos = Convert.ToInt32(Console.ReadLine());
        
        horas = (segundos/60)/60;
        minutos = (segundos - (3600 * horas))/60;
        segundos = ((segundos - (3600 * horas)) - (((segundos - (3600 * horas))/60) * 60));

        Console.WriteLine("{0} Horas, {1} Minutos, {2} Segundos", horas, minutos, segundos);
        
        /* ANOTAÇÕES:
            1 minuto possui 60 segundos
            1 hora possui 60 minutos, 60 minutos possui 3600 segundos
            30 minutos possui 1800 segundos
            O resto seria os segundos não computados anteriormente

            TESTAR:
            1 HORA 30 MINUTOS
            5400 SEGUNDOS = 1 HORA 30 MINUTOS
            1 HORA = 60 MINUTOS = 3600 SEGUNDOS
            30 MINUTOS = 1800 SEGUNDOS
        */

    }
}