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

            //que pasa si la variable de destino es numerica?
            int a, b;
            Console.Write("Digite un numero entero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite otro numero entero: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"La suma de ambos numeros es {a+b}");
        }
    }
}
