namespace _32_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructuras de repeticion while y do-while
            Se usan para realizar iteraciones; pero no sabemos
            cuando vamos a dejar de iterar.
            -> Se basan en el cumplimiento de una o varias condiciones
            -> Imagenenlas como un if que si se cumple va a seguir
               repitiendo lo que hay dentro de él (if iterativo)
            -> diferencia entre ambas estructuras:
                1) while: pregunta primero, hace despues
                2) do-while: hace primero, pregunta despues
            -> while se traduce a mientras
            -> do se traduce al verbo hacer*/

            //ejemplos:
            //Haga un programa que imprima los numeros del 1 al 10 usando while
            int i = 100; //la variable de control se declarar antes de la estructura
            while(i <= 10) //la condicion de terminacion va aqui (como en el if)
            {
                Console.WriteLine(i);
                i++; //la variable de control se cambia manualmente dentro de
                     //la estructura; si no ocurre cambios en la variable
                     //de control; entonces la estructura while se queda infinita.
            }
            //que pasaria si la condicion de terminacion se cumple siempre:
            /*
            i = 1;
            while(i <= 10)
            {
                Console.WriteLine(i);
            }
            */
            //la forma mas popular de establecer un while infinito es la siguiente:
            /*
            while (true)
            {
                Console.WriteLine("Hola hasta el infinito.");
            }
            */
            //ejemplo: ahora con una estructura do-while haga un programa
            //que imprima los numeros del 1 al 10 de 1 en 1
            int x = 100;
            do
            {
                Console.WriteLine(x);
                x++; //modificar la variable de control para que termine
            } while (x <= 10); //condicion de terminacion despues de cada iteracion
            //la estructura do-while SIEMPRE va a hacer la primera iteracion.
            //ya que hace primero, pregunta despues.

        }
    }
}
