namespace _30_for
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

            //forma 2: inicializar la variable bandera en la primera iteracion
            //o sea, el primer numero leido va a ser el mayor y despues lo vamos
            //comparando con los demas para ver quien lo supera.
            int mayor = 777; //no importa como lo inicialice aqui

            //estructura de repeticion para leer 10 numeros y sumarlos al acumulador
            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    numero = int.Parse(Console.ReadLine());

                    //si esta es la primera iteracion, el numero mayor
                    //inicializa con este valor
                    if (i == 1)
                        mayor = numero;
                    else
                    {
                        //en las demas iteraciones vemos si superamos al mayor leido antes
                        if (numero > mayor) mayor = numero;
                    }

                    //sumar el numero recien leido al acumulador
                    suma += numero;
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
