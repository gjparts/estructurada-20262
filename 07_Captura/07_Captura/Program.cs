using System.Runtime.CompilerServices;

namespace _07_Captura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Captura de valores en C# usando la consola de sistema.
             Para ello usaremos un metodo llamado ReadLine()
            el cual devolverá un valor de tipo texto (String)*/
            string nombre;
            Console.Write("Digite su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}");

            

            //bloque de caza de errores en tiempo de ejecucion
            //(runtime exceptions)
            try
            {
                //codigo que puede fallar
                //que pasa si la variable de destino es numerica?
                int a, b;
                Console.Write("Digite un numero entero: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Digite otro numero entero: ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine($"La suma de ambos numeros es {a+b}");
            }
            catch(Exception ex)
            {
                //codigo a ejecutar en caso de falla
                //imprimir un mensaje facil de enteder para el usuario:
                Console.WriteLine("Solo se acepta numeros enteros.");
                //otros programadores eligen imprimir el mensaje del compilador:
                Console.WriteLine(ex.Message);
            }
        }
    }
}
