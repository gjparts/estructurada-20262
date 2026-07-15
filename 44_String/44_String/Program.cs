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
            str += " " + calidad;
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
            Console.WriteLine($"Ultimo caracter de s6: {s6[s6.Length - 1]}");
            Console.WriteLine($"Ultimo caracter de s6: {s6[7]}");
            Console.WriteLine($"Caracter en posicion 4 de s6: {s6[4]}");
            Console.WriteLine($"Penultimo caracter de s6: {s6[s6.Length - 2]}");
            //tambien puede depositar en una variable char algun elemento del String
            char nose = s6[3]; //depositar en nose el caracter 3 de s6
            Console.WriteLine($"Caracter en posicion 3 de s6: {nose}");

            string platillo = "Baleada con todo";
            /*Haga un programa que imprima cada caracter de platillo
             en una nueva linea*/
            for (int i = 0; i < platillo.Length; i++)
            {
                Console.WriteLine(platillo[i]);
            }

            /*en C# no se posible cambiar el valor de un elemento char
             que esta dentro de un String mediante el uso de corchetes*/
            //platillo[0] = 'X';

            //Transformaciones de String
            /*
            Metodo ToUpper()
            Devuelve una version en mayusculas del String
            Metodo ToLower()
            Devuelve una version en minusculas del String
            
            -> Un metodo que devuelve un version de la variable
               en realidad lo que devuelve es una copia con la transformacion
               realizada, o sea no afecta a la variable original.
             */
            string ciudad = "San Pedro Sula";
            Console.WriteLine($"ciudad en mayusculas: {ciudad.ToUpper()}");
            Console.WriteLine($"ciudad en minusculas: {ciudad.ToLower()}");
            Console.WriteLine($"ciudad (variable original): {ciudad}");

            //que pasaria si quiere alterar la variable original?
            //por ejemplo que ciudad quede definitivamente en mayusculas?
            ciudad = ciudad.ToUpper(); //sobreescribir la variable original
            Console.WriteLine($"ciudad (variable original): {ciudad}");

            /*Metodo Trim()
            Devuelve una copia del String a la cual se ha removido los
            espacios en blanco iniciales y finales mas conocidos como
            espacios de relleno.*/
            string persona = "          Gerardo Portillo        ";
            Console.WriteLine($"persona (original): *{persona}*");
            Console.WriteLine($"Longitud de persona (original): {persona.Length}");
            //usando Trim
            Console.WriteLine($"persona (Trim): *{persona.Trim()}*");
            Console.WriteLine($"Longitud de persona (Trim): {persona.Trim().Length}");
            //se habra afectado la variable original?
            Console.WriteLine($"persona (original): *{persona}*");
            Console.WriteLine($"Longitud de persona (original): {persona.Length}");
            //observe que la varaible original no ha sido alterada

            //que escribiria si desea alterar la variable original eliminandole
            //sus espacios de relleno?
            persona = persona.Trim();
            Console.WriteLine($"persona (original): *{persona}*");
            Console.WriteLine($"Longitud de persona (original): {persona.Length}");
            //note que aqui si quedo afectada la variable original

            string bebida = "     Coca Cola 3 Litros       ";
            //Ejercicio: imprima la variable bebida, sin relleno de espacios,
            //en mayusculas y sin alterar la variable original usando una
            //sola instruccion.
            Console.WriteLine(bebida.Trim().ToUpper()); //forma 1
            Console.WriteLine(bebida.ToUpper().Trim()); //forma 2
            //lo anterior es ejecucion de metodos en cascada

            //Concatenar char a String
            string taxi = "Toyota Rav4 2018";
            //concatenar char a string durante la impresion (no afecta string original)
            Console.WriteLine(taxi + 'X');
            Console.WriteLine($"taxi (original): {taxi}");

            //concatenar char a String afectando la variable original:
            taxi = taxi + 'S';
            Console.WriteLine($"taxi (original): {taxi}");

            //concatenar varios char a un string afectando variable original
            string alguien = "Filomeno Colinas";
            alguien = alguien + 'Q' + 'W' + 'E';
            Console.WriteLine($"alguien (original): {alguien}");

            //lo anterior deja de ser practico, si va a concatenar
            //varios char mejor concatene un solo string
            string proveedor = "Gerardo Portillo";
            proveedor = proveedor + "QWE";
            Console.WriteLine($"proveedor (original): {proveedor}");

            //tambien puede llegar a suceder que el char que va a concatenar
            //este dentro de otra variable
            char c1 = 'X';
            string cliente = "Estebancito Maravilla";
            cliente = cliente + c1;
            Console.WriteLine($"cliente (original): {cliente}");

            //tambien puede usar el operador de incremento
            string pet = "Tinieblo";
            pet += 'X';
            Console.WriteLine($"pet (original): {pet}");

            //si va usar el operador de incremento no se recomienda
            //concatenar varios char:
            string empresa = "Repuestos del Atlantico";
            empresa += 'Q' + 'W' + 'E';
            Console.WriteLine($"empresa (original): {empresa}");

            //pero si le funcion con el string completo
            string corporacion = "Capsule Corp.";
            corporacion += "QWE";
            Console.WriteLine($"corporacion (original): {corporacion}");

            /*Haga un programa con una nueva variable string en la cual va a copiar
            cada caracter de la variable empleado, si encuentra un espacio en blanco
            lo va reemplazar por un guion bajo en la variable copia.
            Al terminar va a imprimir la variable copia.
            
            -> Se prohibe usar metodos como Replace o cualquier otro metodo de reemplazo.

            ejemplo, para la varaible empleado que tengo arriba la impresion quedaria:

            Gerardo_Josue_Portillo*/
            string empleado = "Gerardo Josue Portillo";
            string copia = "";

            //forma 1: usando if convencionales
            for (int i = 0; i < empleado.Length; i++)
            {
                if (empleado[i] == ' ') //si el caracter actual es un espacio
                    copia = copia + '_'; //lo que se concatena a copia es guion bajo
                else
                    copia = copia + empleado[i]; //sino se concatena a copia el caracter i
            }
            Console.WriteLine(copia);

            //forma 2: usando el operador ternario
            copia = "";
            for (int i = 0; i < empleado.Length; i++)
            {
                copia = copia + (empleado[i] == ' ' ? '_' : empleado[i]);
            }

            /*Operador Ternario
            Retorna el resultado de evaluar una o varias condiciones.
            Dicho resultado puede tener dos posibilidades:
            a) el resultado a retornar si se cumple la condicion
            b) el resultado a retornar si NO se cumple la condicion
            -> IMPORTANTE: cada uno de los posibles resultaods debe de ser
                           del mismo tipo de dato.*/
            //ejemplos:
            float venta = 1000;
            bool pagaImpuesto = true;
            //si paga impuesto se muestra el valor de la venta mas el 15%
            //si no solo imprime el valor de la venta.
            Console.WriteLine($"Valor a pagar: {(pagaImpuesto == true ? venta * 1.15f : venta)}");

            //asignar el valor mayor por medio de un ternario
            int a = 5, b = 9;
            int mayor = ( a >= b ? a : b );
            Console.WriteLine($"mayor: {mayor}");
        }
    }
}
