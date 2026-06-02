namespace _13_estructura_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura anidada (nested): se le llama asi a una estrcutra
             que esta dentro de otra estructura.
            Para este caso si un if esta dentro de otro if se le conoce
            como if anidado.*/
            int edad;
            Console.Write("Digite su edad: ");
            edad = int.Parse(Console.ReadLine());

            if( edad >= 18 )
            {
                Console.WriteLine("Usted es mayor de edad");
                if( edad >= 21 )
                    Console.WriteLine("Puede tramitar licencia pesada");
                else
                {
                    Console.WriteLine("Puede ir a la carcel pero no esta emancipado");
                    Console.WriteLine("Pero aun no puede tramitar licencia pesada");
                }
            }
            else
                Console.WriteLine("Usted es menor de edad");
        }
    }
}
