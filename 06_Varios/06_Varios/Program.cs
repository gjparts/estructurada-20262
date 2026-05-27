namespace _06_Varios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conversiones
            //en ocasiones se presentará la necesidad
            //de convertir de texto a numero y al viceversa

            //Convertir de texto a numero
            //el tipo de dato para guardar texto se llama String
            //puede usar String o string como prefiera
            //variable de cadena de texto:
            string str = "12345";

            //deseo almacenar el valor de un string en un int:
            int x = int.Parse(str); //hacer la conversion a int
            Console.WriteLine(x);

            //que pasa si el texto no contiene solo numeros?
            /*string fruta = "pera";
            int y = int.Parse(fruta);*/

            //conversiones hacia otros tipos de datos:
            string algo = "5.2456";
            double n = double.Parse(algo);
            Console.WriteLine(n);

            float z = float.Parse(algo);
            Console.WriteLine(z);

            //convertir cualquier dato numerico a texto
            int cifra1 = 765;
            double cifra2 = 52.22;
            float cifra3 = 3.332f;

            string texto = cifra1.ToString();
            Console.WriteLine(texto);

            texto = cifra2.ToString();
            Console.WriteLine(texto);

            texto = cifra3.ToString();
            Console.WriteLine(texto);

            /*Constantes: son valores almacenados en la memoria que no pueden
             ser modificados (inmutables).
            Normalmente los usamos para establecer valores fijos
            que se usaran en varios calculos y que no deberian poder
            ser cambiados por nadie.*/
            const double gravedadTierra = 9.8;
            //toda constante se declara con un valor de inicio.

            //intentemos cambiar la constante anterior:
            //gravedadTierra = 11;
            //lo anterior no se puede hacer porque una constante es de solo lectura

            //una constante es para usar:
            //voy a calcular el peso de algo que esta en la tierra
            double masa = 101.2; //esto es en kilogramos
            Console.WriteLine($"Para una masa de {masa}Kg el peso en la tierra es {masa*gravedadTierra}Newton");

            const double velocidadLuz = 299792458; //metros
            Console.WriteLine($"La velocidad de la luz es {velocidadLuz}");

            /*Tipo de dato Variant
             Permite declarar una variable que adoptará el tipo de dato
            de acuerdo al valor que le asigne al inicializar la variable.
            -> Imporante: el uso de Variant es considerado una mala practica
            de programacion. Pero aun asi van a encontrar gente que los usa.
            */
            var cosa = 7.2; //los Variant se deben inicializar siempre
            Console.WriteLine($"El valor de cosa es {cosa}");
            Console.WriteLine($"El tipo de dato de cosa es {cosa.GetType()}");

            //una vez inicializar un Variant no le puede cambiar el tipo
            //cosa = "Hola";
            //pero si puede cambiarle el valor a uno que sea del mismo tipo
            cosa = 5.4;

            var otro = "Honduras";
            Console.WriteLine($"El valor de otro es {otro}");
            Console.WriteLine($"El tipo de dato de otro es {otro.GetType()}");

        }
    }
}
