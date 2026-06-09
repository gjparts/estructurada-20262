namespace _21_estructura_if_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operador Logico NOT
            invierte el resultado de una expresion logica.
            
            ejemplo: pregunte una edad, para ingresar al tobogan.
            NO SE ADMITE personas con edades entre 0 y 10
            SI SE ADMITE personas que no esten en ese rango.*/
            try
            {
                int edad;
                Console.Write("Edad: ");
                edad = int.Parse(Console.ReadLine());

                //si no usa NOT la expresion seria:
                if( edad >= 0 && edad <= 10 )
                    Console.WriteLine("No puede ingresar al tobogan");
                else
                    Console.WriteLine("Si puede ingresar al tobogan");

                //si prefiere usar NOT la expresion queda:
                if( !(edad >= 0 && edad <= 10) )
                    Console.WriteLine("Si puede ingresar al tobogan");
                else
                    Console.WriteLine("No puede ingresar al tobogan");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Edad debe ser numero entero.");
            }
        }
    }
}
