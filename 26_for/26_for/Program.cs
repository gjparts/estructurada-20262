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


        }
    }
}
