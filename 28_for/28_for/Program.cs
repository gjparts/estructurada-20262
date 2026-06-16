namespace _28_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que lea 10 numeros enteros y al
             * finalizar muestre la suma de los 10 numeros y me va a decir
             * cuántos de esos 10 numeros
             * fueron pares y cuántos fueron impares.*/
            int numero; //variable temporal para ir leyendo el numero a sumar
            int suma = 0; //variable acumulador para ir sumando
            int pares = 0, impares = 0; //variable acumulador para ir contando

            //estructura de repeticion para leer 10 numeros y sumarlos al acumulador
            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    numero = int.Parse(Console.ReadLine());

                    //sumar el numero recien leido al acumulador
                    suma += numero;

                    //determinar si el numero cuenta como par o como impar
                    if (numero % 2 == 0)
                        pares++; //sumar 1 a los pares: pares = pares + 1
                    else
                        impares++; //sumar 1 a los impares: impares = impares + 1
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Solo se admite numeros enteros.");
                }
            }
            //se ha terminado de leer los 10 numeros:
            Console.WriteLine($"La suma es {suma}");
            Console.WriteLine($"Pares: {pares}");
            Console.WriteLine($"Impares: {impares}");
        }
    }
}
