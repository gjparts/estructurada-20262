namespace _44_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tipo de dato String
            Es una colecccion de elementos char
            -> Su tamaño depende de cuántos caracteres tiene almacenados
            -> Cada caracter mide 1 byte (dependiendo del alfabeto que use su sistema operativo)
            -> en C# el tipo de dato String es basado en una clase a partir de la
               cuál podemos crear objetos.
            -> String en terminos tecnicos lo traducen como Cadena de Texto
            -> en C# pueden usar la palabra String o string para crear objetos
               de cadena de texto. (S mayuscula o minuscula)*/

            //declarar objetos de tipo String
            String mensaje = "Hola";
            string saludo = "Hola";
            //String es un ALIAS de string

            /*String es auto-instanciable o sea que no necesita
             de la palabra new para crear un objeto.
            Instanciar es dar memoria a un objeto o sea asignarlo a la memoria RAM*/
            String mascota = "Firulais";
            string campus;
            campus = "San Pedro Sula";
            string color = "verde", carro = "Honda", pais = "Honduras";

            //pero tambien puede seguir instanciando string por medio de new
            //lo cual no es nada eficiente ni práctico
            string nombre = new string("Gerardo");

            //en C# no se puede leer un String sin haberle asignado un valor
            /*string algo;
            Console.WriteLine($"valor de algo: {algo}");*/

            //lo recomendado seria inicializar al menos con un String en blanco
            string algo = "";
            Console.WriteLine($"valor de algo: {algo}");

            //Concatenar String
            //por medio del operador aritmetico suma
            string verdura = "repollo";
            string color2 = "Morado";
            string str = verdura + " " + color2;
            //tambien puede usar el operador de incremento para concatenar String
            string calidad = "PREMIUM";
            str += " "+calidad;
            Console.WriteLine(str);

            //otra forma de concatenar es utilizando el interpolador $
            string marca = "TOYOTA";
            string modelo = "Corolla";
            int anio = 2012;
            string vehiculo = $"{marca} {modelo} {anio}";
            Console.WriteLine(vehiculo);

            //se puede almacenar valores numericos en String?
            //string s1 = 9;
            //por conversion implicita no es posible

            //veamos ahora por conversion explicita?
            //string s1 = (string)9;
            //tampoco se puede

            //entonces conversion por metodo?
            //string s1 = string.Parse(9);
            //no se puede porque String no cuenta con un metodo Parse

            //se podrá por constructor?
            //string s1 = new string(9);
            //en C# tampoco es posible de esta manera

            //existe otra conversion por metodo y es la siguiente
            string s1 = 9.ToString();
            Console.WriteLine(s1);

            //tambien puede aprovechar la ley de precedencia de
            //operador para engañar al proceso de compilacion
            //y funciona en casi todos los lenguajes
            string s2 = "" + 9;
            Console.WriteLine(s2);

            //mas ejemplos:
            string s3 = "" + 3.2589;
            string s4 = 3.2589.ToString();
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            //lo anterior nos va a ser util en interfaz grafica de usuario

            //saber la longitud de un String
            string s5 = "San Pedro Sula";
            Console.WriteLine($"{s5}");
            Console.WriteLine($"Lontigud de s5: {s5.Length}");
            //la Propiedad Length dentro de un String devuelve
            //un valor int el cual indica cuantos caracteres
            //tiene dicho String.

            //tambien puede almacenar este valor en una variable:
            int longitud = s5.Length;
            Console.WriteLine($"Lontigud de s5: {longitud}");

            /*Acceder a los char dentro de un String
            Para cada char dentro de un String su posicion es numerada
            desde 0 hasta Length-1, a esto se le conoce como
            Zero Indexing.
            Para obtener un char dentro de un String en C# se puede
            hacer utilizando corchetes o brackets [] similar a
            como lo hacen en los arreglos..
            OJO: un String en C# no es propiamente un arreglo de char
             */
            string s6 = "Honduras";
            Console.WriteLine($"El valor de s6 es: {s6}");
            Console.WriteLine($"Primer caracter de s6: {s6[0]}");
            Console.WriteLine($"Ultimo caracter de s6: {s6[s6.Length-1]}");
            Console.WriteLine($"Ultimo caracter de s6: {s6[7]}");
            Console.WriteLine($"Caracter en posicion 4 de s6: {s6[4]}");
            Console.WriteLine($"Penultimo caracter de s6: {s6[s6.Length - 2]}");
            //tambien puede depositar en una variable char algun elemento del String
            char nose = s6[3]; //depositar en nose el caracter 3 de s6
            Console.WriteLine($"Caracter en posicion 3 de s6: {nose}");

            string platillo = "Baleada con todo";
            /*Haga un programa que imprima cada caracter de platillo
             en una nueva linea*/
            for(int i = 0; i < platillo.Length; i++)
            {
                Console.WriteLine(platillo[i]);
            }

        }
    }
}
