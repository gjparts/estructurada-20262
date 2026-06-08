namespace _19_estructura_if_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operador Logico OR
            Devuelve true cuando se cumple al menos una de las expresiones
            de comparacion cuando hay mas de una.
            En C#, JAVA, C++, Javascript, Dart para referir a OR se usan dos barras ||
            El caracter barra se puede obtener con ALT+124 en Wnidows
            
            Ejemplo:
            Haga un programa que pregunte tres enteros.
            Si el primer entero es igual a 5 ó
            Si el segundo entero es menor a 10 ó
            Si el tercer entero es mayor a 4
            entonces mostrar el mensaje: VALOR ACEPTADO
            sino mostrar el mensaje: VALOR NO COMPATIBLE.*/
            try
            {
                int a, b, c;
                Console.Write("entero a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("entero b: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("entero c: ");
                c = int.Parse(Console.ReadLine());

                if (a == 5 || b < 10 || c > 4)
                    Console.WriteLine("VALOR ACEPTADO");
                else
                    Console.WriteLine("VALOR NO COMPATIBLE");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros enteros.");
            }

            /*Hay escasez de vacunas de la gripe en un pueblo, por lo que estas
            NO se van a aplicar a personas entre 14 y 55 años por considerarlas
            con sus defensas altas. Haga un programa que pregunte la edad del
            paciente y que determine si se le aplica o no la vacuna.
            -> Resuelvalo utilizando operador logico OR.*/
            try
            {
                int edad;
                Console.Write("Digite su edad: ");
                edad = int.Parse(Console.ReadLine());
                
                if( edad < 14 || edad > 55 )
                    Console.WriteLine("Se le aplica la vacuna");
                else
                    Console.WriteLine("No ocupa vacuna");

                //OR es muy usado para expresar rangos de exclusion (fuera de)
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros enteros.");
            }
        }
    }
}
