namespace _29_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que lea 10 numeros enteros y al finalizar
             muestre la suma de los 10 numeros y va a mostrar cuál es el
             numero mayor de los 10 numeros leídos.
             El programa debe funcionar tambien con números negativos.*/
            int numero; //variable temporal para ir leyendo el numero a sumar
            int suma = 0; //variable acumulador para ir sumando
            
            //Forma 1: inicializar la variable bandera con el numero mas pequeño soportado
            //por el tipo de dato.
            int mayor = int.MinValue; //variable bandera (flag) que determina el numero mayor

            //estructura de repeticion para leer 10 numeros y sumarlos al acumulador
            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    numero = int.Parse(Console.ReadLine());

                    //sumar el numero recien leido al acumulador
                    suma += numero;

                    //si el numero recien leido es mayor al que 
                    //hasta este momento se considera el mas grande
                    //entonces el numero recien leido sera el nuevo mayor
                    if( numero > mayor ) mayor = numero;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Solo se admite numeros enteros.");
                }
            }
            //se ha terminado de leer los 10 numeros:
            Console.WriteLine($"La suma es {suma}");
            Console.WriteLine($"El mayor es {mayor}");
        }
    }
}
