namespace _33_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que pregunte al usuario N cantidad
            de numeros positivos.
            La lectura de numeros va a terminar cuando
            se digite un numero negativo.
            Una vez termine de leerse los numeros, debe imprimir
            la suma de todos los numeros positivos leidos.
            Resuelvalo usando while o do-while.*/

            //usando while
            double numero = 0; //variable de control
            double suma = 0; //variable acumulador
            while(numero >= 0)
            {
                Console.Write("Digite un numero positivo: ");
                numero = double.Parse(Console.ReadLine());
                //solo sumaremos los numeros positivos:
                if (numero >= 0)
                    suma += numero; //suma = suma + numero;
            }
            Console.WriteLine($"La suma de los numeros positivos leidos es {suma}");

            //usando do-while
            double cifra; //variable de control
            double sumatoria = 0; //variable acumulador
            do
            {
                Console.Write("Digite una cifra positiva: ");
                cifra = double.Parse(Console.ReadLine());
                if (cifra >= 0) sumatoria += cifra;
            } while (cifra >= 0);
            Console.WriteLine($"La suma de cifras positivas leidas es {sumatoria}");

        }
    }
}
