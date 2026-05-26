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

            //Metodo Round: redondea un numero a los decimales que definamos
            double a = 3.32, b = 7.5, c = 4.00005, d = 6.0, e = 2.865673462;
            
            //Redondeo a entero (cero decimales)
            Console.WriteLine($"Round de {a} es {Math.Round(a)}");
            Console.WriteLine($"Round de {b} es {Math.Round(b)}");
            Console.WriteLine($"Round de {c} es {Math.Round(c)}");
            Console.WriteLine($"Round de {d} es {Math.Round(d)}");
            Console.WriteLine($"Round de {e} es {Math.Round(e)}");

            //Round tiene un segundo parametro que el opcional
            //este permite definir a cuantos decimales vamos a redondear.
            //redonde a dos decimales:
            Console.WriteLine($"Round a dos decimales de {a} es {Math.Round(a,2)}");
            Console.WriteLine($"Round a dos decimales de {b} es {Math.Round(b,2)}");
            Console.WriteLine($"Round a dos decimales de {c} es {Math.Round(c,2)}");
            Console.WriteLine($"Round a dos decimales de {d} es {Math.Round(d,2)}");
            Console.WriteLine($"Round a dos decimales de {e} es {Math.Round(e,2)}");

            //Metodo Ceiling: devuelve el numero entero superior al valor
            //enviado siempre y cuando halla una parte decimal no importa
            //que esta sea pequeña (redondeo forzado)
            Console.WriteLine($"Ceiling de {a} es {Math.Ceiling(a)}");
            Console.WriteLine($"Ceiling de {b} es {Math.Ceiling(b)}");
            Console.WriteLine($"Ceiling de {c} es {Math.Ceiling(c)}");
            Console.WriteLine($"Ceiling de {d} es {Math.Ceiling(d)}");
            Console.WriteLine($"Ceiling de {e} es {Math.Ceiling(e)}");

            //Metodo Floor: devuelve la parte entera de cualquier numero
            //Floor no redondea.
            Console.WriteLine($"Floor de {a} es {Math.Floor(a)}");
            Console.WriteLine($"Floor de {b} es {Math.Floor(b)}");
            Console.WriteLine($"Floor de {c} es {Math.Floor(c)}");
            Console.WriteLine($"Floor de {d} es {Math.Floor(d)}");
            Console.WriteLine($"Floor de {e} es {Math.Floor(e)}");

            //Como obtengo cuantos decimales tiene la variable a?
            Console.WriteLine($"La parte decimal de {a} es {Math.Round(a-Math.Floor(a),2)}");

            //ejercicios planteados en la pizarra
            double x = 4, y = 9, z = 3;
            Console.WriteLine($"resultado: {Math.Sqrt(x/(y-z))}");
            //que pasaria si dentro de la raiz cuadrada
            //quedara un numero negativo?
            x = 5;
            y = 3;
            z = 9;
            Console.WriteLine($"resultado: {Math.Sqrt(x / (y - z))}");
            //el calculo anterior pretende sacar una raiz
            //cuadrada de un valor negativo
            //esto produce como resultado NaN que
            //quiere decir: Not a Number (no es un numero)
            //por lo tanto no tiene solucion dentro de los numeros reales.

            //que pasaria si el denominador de la division es CERO?
            x = 125.4;
            y = 5;
            z = 5;
            Console.WriteLine($"resultado: {Math.Sqrt(x / (y - z))}");
            //esto dara como resultado INFINITO porque todo numero
            //dividido entre CERO es INFINITO, solo que en algunas
            //computadoras el signo de infinito es un 8, en otras
            //es un 8 acostado, en otros lenguajes sale Inf o Infinite.

        }
    }
}
