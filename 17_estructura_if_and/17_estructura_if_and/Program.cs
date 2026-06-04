namespace _17_estructura_if_and
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Solicite al usuario que digite los enteros para a, b, c.
            Si a es mayor a 7 Y b es menor a 12 Y c es igual a 11 entonces
            muestre el mensaje: COMBINACION CORRECTA, de lo contrario
            mostrara el mensaje: ACCESO NO VALIDO
            -> Resuelvalo utilizando operadores logicos.*/
            try
            {
                int a, b, c;
                Console.Write("entero a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("entero b: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("entero c: ");
                c = int.Parse(Console.ReadLine());

                if (a > 7 && b < 12 && c == 11)
                    Console.WriteLine("COMBINACION CORRECTA");
                else
                    Console.WriteLine("ACCESO NO VALIDO");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Debe digitar solo enteros");
            }


        }
    }
}
