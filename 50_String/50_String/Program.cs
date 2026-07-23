namespace _50_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Método Substring
            Devuelve un string que dentro de otro string.
            -> en C# hay dos formas basicas de usarlo:
            1) Substring(posicion_inicial)
               Devuelve un String a partir de la posicion inicial hasta
               llegar al final.
            2) Substring(posicion_inicial, cantidad_caracteres)
               Devuelve un String a partir de la posicion inicial hasta
               llegar a la cantidad de caracteres definidos.*/
            string frase = "El veloz murcielago hindu comia feliz cardillo y kiwi";
            Console.WriteLine(frase);

            //Substring de 9 caracteres a partir de la posicion 3
            Console.WriteLine(frase.Substring(3,9));

            //el resultado de Substring tambien puede almacenarlo
            //en una variable, por ejemplo tomar 5 caracteres a partir
            //de la posicion 10
            string fragmento = frase.Substring(10, 5);
            Console.WriteLine(fragmento);

            //que pasa cuando Substring quiere tener acceso a una posicion
            //que no existe?
            //por ejemplo, obtener 1000 caracteres desde la posicion 1
            try
            {
                Console.WriteLine(frase.Substring(1,1000));
            }
            catch (Exception)
            {
                Console.WriteLine("Posicion no existe dentro de frase");
            }
            //si Usted sospecha que Substring puede llegar a querer acceder
            //a una posicion inexistente, lo recomendado es colocarlo
            //dentro de una estructura try-catch

            //Substring usando unicamente la posicion inicial
            //obtener todo el texto a partie de la posicion 12
            Console.WriteLine(frase.Substring(12));
            //tambien se puede guardar en una variable:
            //tomar todo el texto desde el caracter 20 y colocarlo en una variable
            string parte = frase.Substring(20);
            Console.WriteLine(parte);
        }
    }
}
