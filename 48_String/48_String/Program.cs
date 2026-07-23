namespace _48_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Arreglode String
            forma 1: arreglo inicializado con valores predeterminados*/
            string[] arreglo1 = new string[5];
            //C# inicializa cada item de este arreglo con un string vacio

            Console.WriteLine("arreglo1: ---------------------");
            for(int i = 0;  i < arreglo1.Length; i++)
            {
                Console.WriteLine(arreglo1[i]);
            }

            //forma 2: arreglo prellenado
            string[] arreglo2 = { "Fresa", "Manzana", "Uva", "Pera", "Melón", "Kiwi" };

            Console.WriteLine("arreglo2: ---------------------");
            Console.WriteLine(String.Join("\n", arreglo2));

            /*Haga un programa que pregunte una fruta.
            Luego el programa va a buscar dicha fruta de arreglo2.
            -> Si la fruta es encontrada, entonces va a imprimir
               la posicion de la primera coincidencia de la fruta.
            -> Comience a contar desde CERO las posiciones.
            -> Si la fruta no es encontrada entonces muestre
               un mensaje indicando que no la encontró.
            -> Deberá ignorar mayusculas/minusculas durante la busqueda*/
            Console.Write("Escriba el nombre de la fruta que desea buscar: ");
            string buscar = Console.ReadLine();
            bool encontrado = false;

            for(int i = 0; i < arreglo2.Length; i++)
            {
                if( buscar.ToLower() == arreglo2[i].ToLower())
                {
                    encontrado = true;
                    Console.WriteLine($"Encontrada en la posicion {i}");
                    break; //si ya la encontramos pues no seguimos buscando
                }
            }
            //busqueda ha terminado
            if(encontrado == false)
                Console.WriteLine("No se encontró");

            //C# les ofrece un metodo mas facil de encontrar algo en una coleccion
            int posicion =
                Array.FindIndex(arreglo2, n => n.Equals(buscar, StringComparison.OrdinalIgnoreCase));
            if (posicion == -1)
                Console.WriteLine("No se encontro");
            else
                Console.WriteLine($"Encontrado la posicion {posicion}");
        }
    }
}
