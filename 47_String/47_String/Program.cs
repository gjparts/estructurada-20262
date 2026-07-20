namespace _47_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Compara dos string en C#
            string a, b;
            Console.Write("Digite string a: ");
            a = Console.ReadLine();
            Console.Write("Digite string b: ");
            b = Console.ReadLine();

            //en C#, C++, Javascript se compara con el operador de igualdad ==
            if( a == b )
                Console.WriteLine("a y b son iguales");
            else
                Console.WriteLine("a y b no son iguales");

            //Importante: C# no ignora mayusculas y minusculas al comparar
            //a esto se le conoce como CASE SENSITIVE

            /*Compare los string a y b; pero ignorando mayusculas/minusculas.
            En estos casos se recomienda colocar el mismo casing en ambos
            lados de la comparacion.*/
            if( a.ToLower() == b.ToLower() )
                Console.WriteLine("a y b son iguales ignorando mayusc./minusc.");
            else
                Console.WriteLine("a y b no son iguales ignorando mayusc./minusc.");

        }
    }
}
