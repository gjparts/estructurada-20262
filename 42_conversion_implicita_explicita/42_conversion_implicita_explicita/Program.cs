namespace _42_conversion_implicita_explicita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Diferencia entre conversion implicita y explicita
            Conversion Implicita
            Consiste en pasar de un tipo mas pequeño hacia un tipo
            mas grande.
            -> Este tipo de conversion es automatica por parte del compilador
            -> Es segura porque se utiliza cuando se sabe que no hay riesgo
               de perdida de datos
            Ejemplo:
             */
            int numero = 10;
            double cifra = numero;
            //note que pudimos depositar un entero dentro de un double
            //porque el entero es de menor precision que el double

            float n = 3.5f;
            double m = n;
            //no hay problema en depositar un numero de menor precision
            //dentro de uno con mayor precision

            /*Conversion Explicita (Cast)
            Consiste en pasar de un tipo de dato mas grande hacia uno
            mas pequeño.
            -> Este tipo de conversion es manual, el programador es quien
               debe decirle al compilador que esta de acuerdo.
            -> Es menor segura porque al pasar de un tipo de mayor precision
               a un tipo de menor precision puede haber perdida por ejemplo
               de decimales.
             */
            double a = 8.7;
            int b = (int)a;
            //conversion explicita no redondea, sino trunca (hay perdida)
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");

            double x = 8.3261535216315647423424234242342343;
            float y = (float)x;
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"y: {y}");

            int r = 7;
            int cuadrado = (int)Math.Pow(r, 2);
            Console.WriteLine($"valor de r: {r}");
            Console.WriteLine($"r al cuadrado: {cuadrado}");
        }
    }
}
