namespace _04_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ley de precedencia de operadores
            Las expresiones se evaluan se izquierda a derecha
            dando prioridad a los operadores de scuerdo a
            la tabla siguiente:
            1) Parentesis ()
            2) Exponentes Math.Pow
            3) Multiplicaciones y Divisiones * /
            4) Sumas y Restas + -
            5) Operadores logicos NOT !
            6) Operadores logicos AND &&
            7) Operadores logicos OR ||
            la barra | la puede obtener con ALT+124
             */
            double d1 = 5, d2 = 9, d3 = 2, d4 = 10;
            Console.WriteLine(d1+d2/d3);
            Console.WriteLine(d1+d2/d3-d4);
            Console.WriteLine((d1+d2)/d3+d4);
            Console.WriteLine(d2*8+(d2/d3)-1);
            //al 8 y al 1 del calculo anterior se les conoce como
            //valores fijos o valores constantes

            //Concatenacion cuando hay operaciones aritmeticas
            Console.WriteLine("La suma de dos mas dos es: "+2+2);
            //lo anterior imprime que la suma de 2+2 es 22
            //lo cual es incorrecto, esto se debe a que el operador
            //de suma en C# es un operador sobrecargado
            //ya que nos sirve para sumar; pero tambien nos sirve
            //para concatenar.
            //para evitar este problema tiene dos soluciones:
            //1) usar parentesis en la expresion aritmetica:
            Console.WriteLine("La suma de dos mas dos es: "+(2+2));
            //2) usar interpolacion de variables
            Console.WriteLine($"La suma de dos mas dos es: {2+2}");

            //otros ejemplos:
            Console.WriteLine("La resta de "+d1+" menos "+d2+" es: "+(d1-d2));
            Console.WriteLine($"La resta de {d1} menos {d2} es {d1-d2}");

            //Solucion a ejercicios en la pizarra:
            Console.WriteLine((d1+d2)/5-d4);
            Console.WriteLine(((d1-d2)/d3)/(2+d4));
            Console.WriteLine((d1/(80*d4)+5)/((d1*2+d3)/8));
        }
    }
}
