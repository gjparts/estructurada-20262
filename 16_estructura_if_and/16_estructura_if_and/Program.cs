namespace _16_estructura_if_and
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operador logico AND
            Hace obligatorio el cumplimiento de una o varias condiciones
            -> en C#, C++, JAVA, Javascript, Dart se representa usando doble ampersand &&
            
            Ejemplo:
            Haga un programa que pregunte la edad a una persona, y que pregunte
            si trabaja. Si la persona es mayor de edad y tiene trabajo entonces
            mostraremos un mensaje: PRESTAMO APROBADO
            de lo contrario: NO APLICA PARA PRESTAMO
             */
            try
            {
                int edad;
                char trabaja;
                Console.Write("Digite su edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Trabaja? (digite S para Si, N para No: ");
                trabaja = char.Parse(Console.ReadLine());

                if( edad >= 18 && trabaja == 'S' )
                    Console.WriteLine("PRESTAMO APROBADO");
                else
                    Console.WriteLine("NO APLICA PARA PRESTAMO");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Los datos proporcionados no son correctos");
            }
        }
    }
}
