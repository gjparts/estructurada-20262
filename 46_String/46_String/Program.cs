namespace _46_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que lea un string, luego el programa
            va a imprimir cuantas veces encontró en dicho string
            las letras: e, b, c, s, a
            -> Ignorando mayusculas y minusculas.
            -> Las tildes no cuentan*/

            int e = 0, b = 0, c = 0, s = 0, a = 0; //acumuladores

            Console.Write("Digite un string: ");
            string str = Console.ReadLine();

            for(int i = 0; i < str.Length; i++)
            {
                if (str.ToLower()[i] == 'e') e++;
                if (str.ToLower()[i] == 'b') b++;
                if (str.ToLower()[i] == 'c') c++;
                if (str.ToLower()[i] == 's') s++;
                if (str.ToLower()[i] == 'a') a++;
            }
            Console.WriteLine($"Cantidad de e: {e}");
            Console.WriteLine($"Cantidad de b: {b}");
            Console.WriteLine($"Cantidad de c: {c}");
            Console.WriteLine($"Cantidad de s: {s}");
            Console.WriteLine($"Cantidad de a: {a}");
        }
    }
}
