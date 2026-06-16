namespace _27_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que lea 10 numeros y al finalizar
             muestre la suma de los 10 numeros.*/
            double numero; //variable temporal para ir leyendo el numero a sumar
            double suma = 0; //variable acumulador para ir sumando
            //toda variable acumulador debe de tener un valor de inicio

            //estructura de repeticion para leer 10 numeros y sumarlos al acumulador
            for(int i = 1; i <= 10; i++)
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    numero = double.Parse(Console.ReadLine());

                    //sumar el numero recien leido al acumulador
                    suma += numero;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Solo se admite numeros.");
                }
            }
            //se ha terminado de leer los 10 numeros:
            Console.WriteLine($"La suma es {suma}");
        }
    }
}
