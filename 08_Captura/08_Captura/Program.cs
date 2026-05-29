namespace _08_Captura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b, c, d;
                Console.Write("a: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c: ");
                c = double.Parse(Console.ReadLine());
                Console.Write("d: ");
                d = double.Parse(Console.ReadLine());

                //existe muchas forma de hacer el calculo
                //forma 1: todo de un solo al imprimir
                Console.WriteLine(Math.Round(Math.Sqrt(a + b)/Math.Pow(c-d,2),2));
                
                //forma 2: por partes
                double numerador, denominador, resultado;
                numerador = Math.Sqrt(a + b);
                denominador = Math.Pow(c - d, 2);
                resultado = Math.Round(numerador / denominador, 2);
                Console.WriteLine(resultado);
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros.");
            }
            

        }
    }
}
