internal class Program
{
    static double Distancia(double x1, double y1, double x2, double y2){
        return Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2))
    }

    static void Main(string[] args){
        double x1,y1,x2,y2,x3,y3,perimetro;
        
        Console.WriteLine("Ponto 1 (x e y):");
        x1 = Convert.ToDouble(Console.ReadLine());
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ponto 2 (x e y):");
        x2 = Convert.ToDouble(Console.ReadLine());
        y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ponto 3 (x e y):");
        x3 = Convert.ToDouble(Console.ReadLine());
        y3 = Convert.ToDouble(Console.ReadLine());

        perimetro = Distancia(x1, y1, x2, y2) +
                    Distancia(x2, y2, x3, y3) +
                    Distancia(x3, y3, x1, y1);

        Console.WriteLine("Perímetro: {0}", perimetro);
    }

}