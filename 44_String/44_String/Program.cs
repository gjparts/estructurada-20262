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


        }
    }
}
