namespace _05_Matematicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Funciones de matematicas en C#
            //dentro del lenguaje existe una clase llama Math, esta
            //contiene una serie de metodos para realizar ciertos calculos

            //Metodo Pow: eleva un numero a determinado exponente
            double valor1 = 9;
            Console.WriteLine($"{valor1} elevado al cuadrado es {Math.Pow(valor1,2)}");
            Console.WriteLine($"{valor1} elevado a la quinta potencia es {Math.Pow(valor1,5)}");

            //el valor de Pow se puede guardar en una variable
            double xyz = Math.Pow(valor1, 22);
            Console.WriteLine($"{valor1} elevado a la 22 potencia es {xyz}");

            //tambien puede usar Pow para calcular raices:
            double valor2 = 27;
            double cubica = Math.Pow(valor2, 1.0/3.0);
            Console.WriteLine($"Raiz cubica de {valor2} es {cubica}");
            /*colocamos 1.0/3.0 en el exponente en lugar de 1/3 porque
             en los lenguajes de programacion el tipo de dato determina
            si la division es de enteros o de doubles.*/
            Console.WriteLine($"La division de 1/3 es {1/3}");
            Console.WriteLine($"La division de 1.0/3.0 es {1.0/3.0}");

            //la clase Math tambien incluye algunas constantes precalculadas
            //las mas conocidas son PI y EULER
            Console.WriteLine($"El valor de pi es {Math.PI}");
            Console.WriteLine($"La constante de Euler es {Math.E}");

            //Calculo de logaritmos
            double valor3 = 2;
            Console.WriteLine($"El logaritmo de {valor3} es {Math.Log(valor3)}");
            Console.WriteLine($"El logaritmo base 10 de {valor3} es {Math.Log10(valor3)}");

            //recuerde que el resultado de toda funcion de Math se puede guardar
            //en un variable, por lo general double
            double logaritmo = Math.Log(valor3);
            Console.WriteLine($"El logaritmo de {valor3} es {logaritmo}");

            //Metodo Sqrt: calcula la raiz cuadrada de un numero (Square root)
            double valor4 = 81;
            Console.WriteLine($"La raiz cuadrada de {valor4} es {Math.Sqrt(valor4)}");

            //tambien puede guardar el resultado en una variable double:
            double raiz = Math.Sqrt(valor4);
            Console.WriteLine($"La raiz cuadrada de {valor4} es {raiz}");


        }
    }
}
