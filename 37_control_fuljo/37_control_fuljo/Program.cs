namespace _37_control_fuljo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Instrucciones de control de flujo
            Permiten alterar el flujo dentro de una estructura
            de repeticion, normalmente son dos:
            1) continue: termina con la iteracion actual y pasa a la siguiente
            2) break; termina con estructura de repeticion*/

            /*Ejemplo de uso: Haga un programa que recorra los numeros
             del 1 al 100. Debera imprimir todos los numeros
            excepto aquellos que sea multiplos de 7.
            -> Resuelvalo utilizando al menos una vez la instruccion continue.*/
            for(int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0) continue; //si es multiplo de 7 saltamos la iteracion actual

                Console.WriteLine(i);
            }

            /*Otro ejemplo: Haga un programa que lea N cantidad de numeros
             enteros, solo va a sumar aquellos que sean positivos.
            Si digita un numero negastivo debera saltarse esa iteracion.
            El programa termina cuando digite CERO.
            Al finalizar muestre la suma de los enteros leidos.
            -> Debe utilizar continue al menos una vez.*/
            try
            {
                int numero; //variable de control y variable bandera
                int suma = 0; //variable acumulador

                //puede usar while o do-while
                do
                {
                    Console.Write("Digite un numero entero:");
                    numero = int.Parse(Console.ReadLine());

                    if (numero < 0) continue; //negativo salta la iteracion actual
                    suma += numero; //sumar el numero leido al contador
                } while (numero != 0);
                Console.WriteLine($"Suma de los numeros positivos leidos: {suma}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros enteros.");
            }
        }
    }
}
