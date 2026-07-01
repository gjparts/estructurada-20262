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

        }
    }
}
