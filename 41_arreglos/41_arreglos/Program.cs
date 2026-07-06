namespace _41_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que pregunte al usuario 5 numeros double.
            Debera almacenar dichos numeros en un arreglo.
            Una vez finalizada la captura de datos deberá mostrar lo siguiente:
            -> Imprimir cada numero leido elevado al cubo; pero en orden ascendente
            -> Imprima la suma de todos los numeros leidos
            -> Imprima el promedio de todos los numeros leidos
            -> Imprima el mayor y el menor de todos los numeros leidos*/
            
            //declarar arreglo
            double[] arreglo = new double[5];
            
            //recorrer arreglo e ir depositando numero double leido
            for(int i = 0;  i < arreglo.Length; i++)
            {
                //depositar numero leido en el i-esimo elemento del arreglo
                Console.Write("Digite numero: ");
                arreglo[i] = double.Parse(Console.ReadLine());
            }

            //analizar la informacion
            double suma = 0; //acumulador
            Array.Sort(arreglo); //aplicar orden ascendente
            Console.WriteLine("Numeros leidos elevados al cubo en orden ascendente:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                suma += arreglo[i]; //sumar numero leido
                Console.WriteLine(Math.Pow(arreglo[i],3)); //imprimir numero leido elevado al cubo
            }
            Console.WriteLine($"La suma de los numeros leidos es: {suma}");
            Console.WriteLine($"El promedio de los numeros leidos es: {suma/arreglo.Length}");
            Console.WriteLine($"Valor mayor: {arreglo.Max()}");
            Console.WriteLine($"Valor menor: {arreglo.Min()}");
        }
    }
}
