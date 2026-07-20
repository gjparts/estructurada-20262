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


        }
    }
}
