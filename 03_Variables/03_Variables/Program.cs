namespace _03_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Variable:
            Es un espacio de almacenamiento temporal que esta dentro de la memoria principal (RAM)
            utilizado para almacenar valores, estos pueden cambiar  durante la vida del programa.
            Toda variable idealmente debe de tener un tipo de dato el cual dicta
            la naturaleza de la informacion que almacena.
            Por ejemplo: numeros, texto, fechas, objetos, etc.
            
            Los tipos de dato se agrupan en:
            1) Tipos de dato primitivos: son los que vienen definidos dentro del compilador/interprete
               del lenguaje de programacion.
               Ejemplo, en C++ y C# se considera tipos primitivos a int, float, char, double, bool, long

            2) Tipos de dato compuestos: son los que estan conformados por una coleccion de datos
               de diferente tipos, ya sean compuestos o primitivos.
               Ejemplo, en C++ el string (es una coleccion de datos char)
               en C# podemos encontrar a String, Array, List, Class, Enum
            
            Reglas para nombrar variables:
            1) Dos variables no pueden tener el mismo nombre dentro del mismo ambito
            2) No usar espacios en blanco en los nombres de variables
            3) No use caracteres especiales en los nombres de variables (puede usar guion bajo)
            4) No usar numeros al inicio del nombre de la variable
            5) No utilice palabras reservadas de su lenguaje para nombrar variables
               por ejmplo, no use palabras como if, for, while.
            6) Cuando nombre su variable asegurese que este tenga sentido.
            7) Recuerde que las variables en lenguajes como C++, C# y Java toman en cuenta
               el uso de mayusculas y minusculas. Por ejemplo puedo tener una variable
               que se llame Gato y otra variable que se llame gato, y esto sera perfectamente
               valido. Se llaman parecido pero no son la misma variable, asi que sean cuidadosos:
             */
            int Edad;
            int edad;
            int EDAD;
            int EdAd;
            int EDad;
            //lo anterior es permitido; pero es confuso.

            //si necesita usar espacios en blanco para nombrar variables
            //puede usar guion bajo (snake case):
            int edad_del_estudiante;

            //Al nombrar variables existen diferentes notaciones que son
            //aceptadas internacionalmente.
            //Notacion Pascal Case
            //consiste en nombrar cada palabra de la variable iniciando con Mayusculas
            //no se usan guiones bajos., ejemplos:
            int EdadEstudiante;
            double SalarioMensualEmpleado;

            //Notacion Hungara o Camel Case (usado por programadores en Java)
            //el nombre de la variable inicia en minuscula y cada palabra siguiente
            //se coloca en mayuscula, ejemplos:
            int edadEstudiante;
            double salarioMensualEmpleado;

            //Notacion Snake Case (usado mucho en python)
            //se usa guiones bajos para separar cada palabra, todo va en minusculas. ejm:
            int edad_estudiante;
            double salario_mensual_empleado;

            //ejemplos prácticos:
            //C# guarda similitudes con C++
            //declarar una variable sin valor de inicio (sin inicializar):
            int algo;
            //lo anterior declara una variable de tipo entero (int)
            //el nombre de la variable es algo.
            //en C# si no le asigna un valor de inicio a una variable
            //esta no podrá ser leida.
            //Console.WriteLine(algo);

            //para poder leer la variable algo debemos colocarle un valor:
            algo = 11;
            Console.WriteLine(algo);

            //declarar e inicializar una variable:
            int a = 237;
            Console.WriteLine(a);

            //declara multiples variables del mismo tipo en una sola instruccion:
            //sin valor de inicio:
            int num1, num2, num3;
            //con valor de inicio:
            int cifra1 = 9, cifra2 = 56, cifra3 = -7;

            Console.WriteLine(cifra2);
            Console.WriteLine(cifra3);

            //int se utiliza para definir variable que almacenan
            //un numero entero de 4 bytes o sea 32 bit.
            //2 elevado a la 31 = 21,47,483,648

            //tipos de datos para almacenar numeros decimales:
            //float: guarda numeros con decimales de 4 bytes (32 bit)(decimal de baja precision)
            //double: guarda numeros con decimales de 8 bytes (64 bit)(decimal de alta precision)
            float salario = 14230.45f;
            //observe que al final del valor para float debe usarse el caracter f
            float pesoPersona = 175.2F;
            //la f tambien puede ser mayuscula
            //Use el tipo float cuando no necesite guardar valores que lleven muchos decimales
            //como por ejemplo dinero, pesos

            double distancia = 40100122345.2344354346234;
            //cuando necesite mucgos decimales y almacenar valores grandes
            //use el tipo double. Este no necesita ningun caracter especial al final.
            double valorPi = 3.141592653589793;
            //double se usa en calculos de tipo cientifico

            //tipo de dato Long
            //se usa para almacenar numeros enteros de alta precision (8 bytes, 64 bit)
            long enteroLArgo = 1234123412345L;
            //en tipos Long se recomienda colocar una L mayuscula al final.

            //tipo de dato char: almacena un caracter
            //mide 1 byte (8 bit)
            char c1 = 'x';

            //la comilla simple se puede obtener
            //presionando la combinacion ALT+39

            char c2 = '4';
            char c3 = ' ';
            char c4 = '\\'; //slash inverso como char
            char c5 = '"'; //comilla doble
            char c6 = '\''; //comilla simple
            //char solo permite cuardar un caracter.
            //excepto cuando se usa caracter de escape \

            //char c7 = '';
            //char debe llevar al menos un caracter dentro de las comillas

            //tipo de dato boolean: guarda true o false (1 bit)
            //se llama asi en honor del matematico George Boole
            //true almacena 1
            //false almacena 0
            bool respuesta = true;
            bool opcion = false;

            //formas de imprimir el valor de una variable
            //en C#

            //forma 1: concatenar la variable
            Console.WriteLine("El valor de salario es "+salario);
            Console.WriteLine("El valor de respuesta es "+respuesta);
            Console.WriteLine("El valor de c4 es "+c4);
            Console.WriteLine("El valor de pesoPersona es "+pesoPersona);

            //forma 2: usando interpolacion de string
            Console.WriteLine($"El valor de salario es {salario}");
            Console.WriteLine($"El valor de respuesta es {respuesta}");
            Console.WriteLine($"El valor de c4 es {c4}");
            Console.WriteLine($"El valor de pesoPersona es {pesoPersona}");

            //interpolar facilita el trabajo cuando quiero desplegar
            //muchas variables:
            int x = 3, y = 9;
            //concatenar:
            Console.WriteLine("El valor de x es "+x+", el valor de y es "+y);
            //interpolar:
            Console.WriteLine($"El valor de x es {x}, el valor de y es {y}");

            //uso de elementos char en la concatenacion
            char ch1 = 'A', ch2 = 'B';
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            //lo siguiente imprime la suma de los valores
            //numericos del caracter A mas B (A vale 65, B vale 66 en la tabla ASCII)
            Console.WriteLine(ch1+ch2);
            //para evitar lo anterior puede hacer lo siguiente:
            Console.WriteLine(""+ch1+ch2);
            //para conocer el valor numerico de una variable char:
            Console.WriteLine(0+ch1);
            Console.WriteLine(0+ch2);
        }
    }
}
