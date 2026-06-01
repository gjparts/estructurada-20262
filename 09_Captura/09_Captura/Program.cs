namespace _09_Captura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio de la pizarra
            double a, b, c;
            Console.Write("a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = double.Parse(Console.ReadLine());

            //por partes:
            double numerador, denominador, raiz, resultado;
            numerador = a + b;
            denominador = Math.Pow(c + 1, 3);
            raiz = Math.Sqrt(numerador / denominador);
            resultado = raiz / 7.0;
            Console.WriteLine($"Resultado: {resultado}");

            //en una sola instruccion
            Console.WriteLine($"Resultado: {Math.Sqrt((a+b)/Math.Pow(c+1,3))/7.0}");
        }
    }
}
