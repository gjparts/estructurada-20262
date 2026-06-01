namespace _10_estructura_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura de seleccion if
             Condiciona el flujo del programa dependiendo de si se cumple
            o no una o varias condiciones.
            ejemplos base:
            
            1) cuando solo necesito condicionar algo:

             if( condicion )
                lo que se va a ejecutar si se cumple la condicion
            
            2) cuando necesito condicionar algo; pero en caso de no
               cumplirse necesito ejecutar otra cosa:

             if( condicion )
                lo que se va a ejecutar si se cumple la condicion
             else
                lo que se va a ejecutar si NO se cumple la condicion
             */

            double a, b;
            Console.Write("a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = double.Parse(Console.ReadLine());

            //forma 1: if sin else
            if( a > b )
                Console.WriteLine("a es mayor que b");

            //forma 2: if con else
            if (a == b)
                Console.WriteLine("a es igual que b");
            else
                Console.WriteLine("a no es igual que b");

            //uso de llaves en if:
            //Las llaves {} en una estructura if o if-else
            //se recomienda su uso solo si lo que se condiciona
            //es mas de una instruccion, ejemplos:
            int edad;
            Console.Write("Digite su edad: ");
            edad = int.Parse(Console.ReadLine());

            //cuando condiciona mas de una instruccion el uso de llaves es obligatorio
            if( edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
                Console.WriteLine("Usted puede ir a la carcel si viola la ley");
                Console.WriteLine("Usted ya puede solicitar empleo legalmente");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad");
                Console.WriteLine("Todo lo que haga responden sus padres");
                Console.WriteLine("Usted deberia estar en la escuela");
                Console.WriteLine("Legalmente no puede ser contratado en Honduras");
            }

            if( edad >= 21)
            {
                Console.WriteLine("A esta edad ya puede casarse sin permiso de sus padres");
                Console.WriteLine("A esta edad ya puede solicitar licencia de conducir pesada");
            }

            //cuando es solo una instruccion, el uso de llaves es opcional:
            if( edad < 6 )
                Console.WriteLine("Deberia cursar kinder");

            if (edad < 6)
            {
                Console.WriteLine("Deberia cursar kinder");
            }
        }
    }
}
