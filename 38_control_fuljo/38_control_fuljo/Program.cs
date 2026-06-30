namespace _38_control_fuljo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Instruccion break: termina con la estr. de repeticion (bucle)
             Ejemplo: Haga una estructura for que lea 10 numeros long positivos.
            -> Si durante la digitacion se ingresa un numero negativo
               entonces se termina la lectura de numeros.
            -> Al finalizar el programa muestre la suma de los numeros leidos.*/
            try
            {
                long numero; //variable bandera
                long suma = 0; //variable acumulador
                for(int i = 1; i <= 10; i++)
                {
                    Console.Write("Digite un entero positivo: ");
                    numero = long.Parse(Console.ReadLine());

                    if (numero < 0) break; //rompemos la estructura for
                    suma += numero;
                }
                Console.WriteLine($"La suma de enteros positivos es: {suma}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros enteros.");
            }
        }
    }
}
