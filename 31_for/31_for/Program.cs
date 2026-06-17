namespace _31_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que lea 10 numeros double y al finalizar
            muestre el promedio de los 10 numeros leidos y va a mostrar cuál es el
            numero mayor y el numero menor de los 10 numeros leídos.
            El programa debe funcionar tambien con números negativos..
            -> Imprima el promedio a maximo cuatro decimales*/

            double numero; //variable temporal para ir leyendo el numero a sumar
            double suma = 0; //variable acumulador para ir sumando
            double mayor = double.MinValue, menor = double.MaxValue; //variables bandera

            //estructura de repeticion para leer 10 numeros y sumarlos al acumulador
            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    numero = double.Parse(Console.ReadLine());

                    //sumar el numero recien leido al acumulador
                    suma += numero;

                    if (numero > mayor) mayor = numero;
                    if (numero < menor) menor = numero;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Solo se admite numeros enteros.");
                }
            }
            double promedio = suma / 10.0;
            //se ha terminado de leer los 10 numeros:
            Console.WriteLine($"La suma es {suma}");
            Console.WriteLine($"El promedio es {Math.Round(promedio,4)}");
            Console.WriteLine($"El mayor es {mayor}");
            Console.WriteLine($"El menor es {menor}");
        }
    }
}
