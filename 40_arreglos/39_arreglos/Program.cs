namespace _39_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Arreglo (Array)
            Es una estructura de datos estatica, secuencial y homogenea la cual
            permite agrupar datos en una coleccion (multiplicidad).
            
            -> Estatica: no puede cambiar su tamaño y existe en una posicion
                         fija en la memoria. Lo opuesto a estatico es dinamico.
            -> Secuencial: Todos sus elementos se almacenan uno despues del otro
                           en la memoria. Lo puesto a secuencial es lo aleatorio.
            -> Homogenea: Todos sus elementos son del mismo tipo de dato.
                          Lo opuesto a homogeneo es heterogeneo.
            
            Todos los elementos en un arreglo en C#, C++, Java, Javascript se numeran
            de 0 a N-1 a esto se le conoce como Zero Indexing.

            El arreglo es una estructura de datos recomendada para volumenes de informacion
            pequeños, si lo quiere utilizar con grandes volumenes de informacion lo mas
            recomendado es usar Lista Vinculada, Colecciones, Tablas Hash, Mapas de valores, etc.

            Maneras de declarar arreglos en C#:
            1) Declarar el arreglo sin datos
            2) Declarar e inicializar el arreglo con datos predeterminados
            3) Declarar e inicializar el arreglo prellenado con datos
            */

            //1) Declarar el arreglo sin datos
            int[] arreglo;
            /*Este arreglo solo esta declarado; pero no inicializado
             por lo tanto no se puede utilizar ya que no le hemos
            asignado memoria. Mas adelanta vamos a ver de que manera nos puede
            servir un arreglo declarado que no esta inicializado.*/

            //2) Declarar e inicializar el arreglo con datos predeterminados
            int[] arreglo1 = new int[5];
            /*Este arreglo si se puede usar porque le asignamos memoria,
             la instruccion new permite instanciar un nuevo objeto en este
            caso le decimos que inicialice el arreglo reservando 5 espacios
            para enteros.
            En C# cuando inicializamos un arreglo de esta manera el valor predeterminado
            para cada elemento será CERO.*/

            //saber la longitud de un arreglo
            Console.WriteLine($"La longitud de arreglo1 es: {arreglo1.Length}");

            //Length devuelve un int, tambien lo puede almacenar en una variable
            int longitudArreglo = arreglo1.Length;
            Console.WriteLine($"La longitud de arreglo1 es: {longitudArreglo}");

            //Leer cada elemento del arreglo
            Console.WriteLine(arreglo1[0]); //leer el primer elemento de arreglo1
            //coloque dentro de los brackets la posicion que desea leer o escribir
            Console.WriteLine(arreglo1[1]);
            Console.WriteLine(arreglo1[2]);
            Console.WriteLine(arreglo1[3]);
            Console.WriteLine(arreglo1[4]); //El ultimo elemento tiene indice N-1

            //que pasaria si quiero leer un indice inexistente en un arreglo?
            //Console.WriteLine(arreglo1[5]);

            //escribir manualmente valores a un arreglo:
            arreglo1[3] = 100;
            arreglo1[1] = 777;
            arreglo1[4] = -20;

            //recorrer e imprimir el contenido de un arreglo usando for
            for(int i = 0; i < arreglo1.Length; i++)
            {
                Console.WriteLine($"Posicion: {i}, Valor: {arreglo1[i]}");
            }

            //hacer un nuevo arreglo unidimencional de numeros double de 10 elementos
            //y llenelo con numeros al azar entre 1 y 100, al final imprima el contenido
            //del arreglo.
            double[] arreglo2 = new double[10];
            Random r = new Random();
            for(int i = 0;i < arreglo2.Length; i++)
            {
                //asignar valor al i-esimo elemento
                arreglo2[i] = r.Next(1,101);
                Console.WriteLine(arreglo2[i]);
            }

            /*en C# existe otros metodos para imprimir arreglos.
             Uno de los mas conocidos es el uso de la estructura
            de repeticin foreach.
            Si Usted decide usar foreach para imprimir un arreglo
            no tendrá acceso al indice o sea la posicion de cada elemento
            y tampoco podrá escribir el elemento en el arreglo.*/
            Console.WriteLine("imprimir arreglo2 usando foreach: ---------");
            foreach(double valor in arreglo2)
            {
                //valor = r.Next(1, 101); //foreach no permite escribir el arreglo
                Console.WriteLine(valor);
            }

            Console.WriteLine($"Primer elemento de arreglo2 es: {arreglo2[0]}");
            Console.WriteLine($"Ultimo elemento de arreglo2 es: {arreglo2[9]}");
            Console.WriteLine($"Ultimo elemento de arreglo2 es: {arreglo2[arreglo2.Length-1]}");

            //en C# los arreglos tienen metodos como por ejemplo para saber
            //cuales son los valores maximo y minimo dentro de ellos.
            Console.WriteLine($"El valor mayor en arreglo2 es: {arreglo2.Max()}");
            Console.WriteLine($"El valor menor en arreglo2 es: {arreglo2.Min()}");

            /*Haga un arreglo unidimensional de numeros double de 20 elementos.
            llene dicho arreglo con numeros al azar entre 5 y 65; pero elevado
            al cuadrado.
            Para los elementos cuyo indice es multiplo de 5 el valor a colocar
            va a ser el valor de PI.
            Por ultimo imprima dicho arreglo, asi como el valor mayor y menor dentro
            del mismo.*/
            double[] arreglo3 = new double[20];
            for(int i = 0; i < arreglo3.Length; i++)
            {
                if (i % 5 == 0)
                    arreglo3[i] = Math.PI;
                else
                    arreglo3[i] = Math.Pow(r.Next(5, 66), 2);

                Console.WriteLine(arreglo3[i]);
            }
            Console.WriteLine($"El mayor es: {arreglo3.Max()}");
            Console.WriteLine($"El menor es: {arreglo3.Min()}");
        }
    }
}
