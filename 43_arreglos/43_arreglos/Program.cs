namespace _43_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa donde declare un arreglo unidimensional
            de numeros enteros de 10 posiciones.
            Lo va a llenar con numeros al azar entre 3 y 14

            Luego declare un segundo arreglo unidimensional
            de numeros enteros de 10 posiciones y va a copiar
            todos los numeros del primer arreglo hacia el
            segundo arreglo pero elevados al cubo.

            Al finalizar imprima los valores del primer y segundo
            arreglo de la siguiente manera:

            5	125
            3	27
            8	512
            10	1000
            3	27
            1	1
            2	8
            3	27
            12	1728
            5	125

            El contenido del arreglo1 a la izquierda y el del
            arreglo2 a la derecha*/
            int[] arreglo = new int[10];
            Random r = new Random();
            //llenar primer arreglo
            for(int i = 0;  i < arreglo.Length; i++)
            {
                arreglo[i] = r.Next(3, 15);
            }

            //copiar valores al cubo de primer arreglo en el segundo
            int[] arreglo2 = new int[10];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo2[i] = (int)Math.Pow(arreglo[i], 3);
            }

            //imprimir
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"{arreglo[i]}\t{arreglo2[i]}");
            }

            //Otra forma de imprimir arreglos si necesidad de for
            long[] arreglo3 = { 123, 4, 1000000000, 1401198201055, 678456, -6546 };

            //en C# la clase String cuenta con un metodo llamado Join
            //el cual se utiliza para convertir los elementos de una coleccion
            //en una sola cadena de texto la cual se puede imprimir o utilizar
            //en lo que desee.
            Console.WriteLine( String.Join("\n",arreglo3 ) ); //\n es el separadoe (nueva linea)
            Console.WriteLine( String.Join(", ", arreglo3 ) ); //separado por coma y espacio
            Console.WriteLine(String.Join(":::", arreglo3)); //separa por :::

            //esta solucion no les da control sobre cada item
        }
    }
}
