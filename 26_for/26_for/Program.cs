namespace _26_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura de repeticion for
            Permite repetir una o varias instrucciones
            -> Su principal caracteristica es que
               es una estructura de repeticion pensada
               para ser finita, ya que tiene definido
               un valor de inicio y valor final.
            
             ejemplo:
            Haga un programa que imprima los numeros
            del 1 al 10 contanto de 1 en 1.
             */
            for(int i = 1; i <= 10; i++)
                Console.WriteLine(i);

            /*donde:
             int i = 1  es la inicializacion de
                        de la variable de control
             i <= 10    es la condicion de terminacion
                        indica que mientras se cumpla
                        dicha condicion la estructura
                        for va a repetir la instruccion
            i++         conocido como step ó salto
                        indica cuanto va a incrementarse
                        o decrementarse la variable de control
                        en cada ciclo, vuelta o iteracion.
                        -> i++ indica que i va a sumar 1 en cada
                        iteracion.
                        -> i++ es lo mismo que dice i = i + 1;
                        */
            //el for del ejemplo anterior solo ejecuta
            //una instruccion, por eso no lo coloque entre llaves
            //pero si necesita repetir mas de una instruccion en cada
            //iteracion entonces amerita usar llaves, por ejemplo:

            /*Haga un programa que imprima los numeros
            del 1 al 10 contanto de 1 en 1; pero tambien debe decir
            Hola despues de imprimir cada numero.*/
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Hola");
            }
            /*El uso de llaves es obligatorio si lo que va a repetir es MAS de
             * una instruccion y es OPCIONAL si lo que va a repetir es solo UNA instruccion.*/

            //Haga un programa que imprima los numeros del 0 al 5, de 1 en 1.
            for(int i = 0; i <= 5; i++)
                Console.WriteLine(i);

            //Haga un programa que imprima los numeros del 1 al 10, de 1 en 1
            //pero de una forma distinta a como ya lo habiamos hecho.
            //aunque no sea la mas entendible o eficiente...
            for(int i = 1; i <= 10 && i > 0; i++)
                Console.WriteLine(i);
            //observe que en la condicion de terminacion hay un AND
            //el cual esta de más, no esta malo; pero hace trabajo desperdiciado

            //otra solucion no tan clara
            for(int i = 1; i < 11; i++)
                Console.WriteLine(i);

            //otra solucion no tan clara
            for(int i = 0; i < 10;i++)
                Console.WriteLine(i+1);
            //en este el valor de i va de 0 a 9; pero imprimimos dicho valor
            //sumandole 1; esto confunde la lectura del codigo
            //todo codigo deberia ser claro en su primera lectura.

            //Imprima los numeros del 0 al 50, de dos en dos.
            for (int i = 0; i <= 50; i+=2)
                Console.WriteLine(i);

            //el codigo anterior hace 26 iteraciones o ciclos
            //esto se debe a que va de 0 a 50 pero haciendo
            //incrementos de 2 en 2 y como comienza desde CERO
            //pues tambien este se cuenta, siendo 26 ejecuciones
            //del codigo.

            /*usar i++ o usar i+=2 a estas soluciones
             se les conoce como operador de incremento.
            i++     es lo mismo que decir i = i + 1
            i+=2    es lo mismo que decir i = i + 2
             */
            //En el step del for no necesariamente esta obligado
            //a usar operador de incremento, puede poner la expresion
            //completa:
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i <= 50; i = i + 2)
                Console.WriteLine(i);
            Console.ResetColor();

            //3) Imprimir los numeros del 0 al 50 de cinco en cinco
            //suma tradicional (11 iteraciones)
            Console.WriteLine("-------------------------");
            for (int i = 0; i <= 50; i = i + 5)
                Console.WriteLine(i);

            //usando operador de incremento (11 iteraciones)
            Console.WriteLine("-------------------------");
            for (int i = 0; i <= 50; i+=5)
                Console.WriteLine(i);

            //mas largo y menos eficiente (51 iteraciones)
            Console.WriteLine("-------------------------");
            for (int i = 0; i <= 50; i++)
                if(i%5 == 0)
                    Console.WriteLine(i);

            //4) Recorrer los numeros del 1 al 50 pero solo imprima los impares
            //50 iteraciones
            Console.WriteLine("-------------------------");
            for(int i = 1; i <= 50; i++)
                if(i%2 == 1)
                    Console.WriteLine(i);

            //5) Imprima los numeros del 1 al 100, coloque un asterisco
            //a la derecha de cada numero que sea multiplo de 10
            Console.WriteLine("-------------------------");
            for(int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                    Console.WriteLine($"{i}*");
                else
                    Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i);
                if(i%10==0) Console.Write("*");
                Console.WriteLine();
            }

            //puede hacer tambien usando algo conocido como OPERADOR TERNARIO
            Console.WriteLine("-------------------------");
            for (int i = 1; i <= 100; i++)
                Console.WriteLine($"{i}{( i%10 == 0 ? "*" : "" )}");

            //Mas ejemplos de operador ternario
            bool pagaImpuesto = true;
            float total = 100;
            Console.WriteLine($"El total es: {total}");
            Console.WriteLine($"El valor a pagar es: {(pagaImpuesto == true ? total*1.15 : total)}");

            int a = 8, b = 15;
            Console.WriteLine($"El mayor es: {(a >= b ? a : b)}");

            //6) Imprima los numeros del 10 al 1, de 1 en 1 de forma descendente.
            Console.WriteLine("-------------------------");
            for(int i = 10; i >= 1; i--)
                Console.WriteLine(i);

            /*Operadores de decremento:
             i--    es lo mismo que decir i = i - 1
             i-=2   es lo mismo que decir i = i - 2*/

            //7) Imprima los numeros del 100 al 0, de 10 en 10 de forma descendente
            Console.WriteLine("-------------------------");
            for (int i = 100; i >= 0; i-=10)
                Console.WriteLine(i);

            //soluciona, solo que un poco mas confuso
            Console.WriteLine("-------------------------");
            for (int i = 100; i > -1; i -= 10)
                Console.WriteLine(i);

            /*La estructura for tambien funciona con otros tipos de datos numericos
             por ejemplo:
            Imprima los numeros del 0 al 6 de 0.25 en 0.25 ascendente*/
            Console.WriteLine("-------------------------");
            for (double i = 0; i <= 5; i+=0.25)
                Console.WriteLine(i);

        }
    }
}
