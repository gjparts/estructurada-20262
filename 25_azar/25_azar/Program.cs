namespace _25_azar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Generacion de numeros aleatorios o al azar en C#
            Generar un numero al azar entre 1 y 6*/

            //instanciar un objeto de clase Random
            Random generador = new Random();
            int azar = generador.Next(1,7);
            Console.WriteLine(azar);
            /*Si es un numero al azar entre 1 y 6, porque le colocamos 7?
             Next es un metodo de Random que espera dos parametros
             el primero es el numero mas pequeño esperado,
             el segundo es el numero mas grande esperado; pero en esdte caso
             C# es excluyente en el numero mas grande, por lo tanto debemos
             sumarle 1 al numero mas grande esperado.*/

            //genere un numero al azar entre 17 y 59
            azar = generador.Next(17, 60);
            Console.WriteLine(azar);

            //genere un numero al azar entre -8 y -22
            azar = generador.Next(-22, -7);
            Console.WriteLine(azar);

            /*Haga un programa que genere un numero al azar entre 5 y 9
            El programa va a imprimir como se escribe el numero
            generado en el idioma inglés.
            -> Resuelvalo sin utilizar if, sino usando switch.*/
            azar = generador.Next(5, 10);
            switch (azar)
            {
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }

            //Adicion al tema:
            //numero al azar double entre 1 y 10
            double x = generador.NextDouble()*10;
            Console.WriteLine(x);
            
            //numero al azar double entre 3 y 7
            x = generador.NextDouble() * (7-3)+3;
            Console.WriteLine(x);

            //NextDouble en Random devuelve un numero decimal: >= 0 Y < 1
            //lo que se traduce en un porcentaje. 0.3333 es lo mismo que decir 33%
        }
    }
}
