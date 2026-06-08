namespace _20_estructura_if_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que pregunte el mes y el año como numeros
             enteros, el programa va a imprimir cuántos días tiene el
            mes/año digitados.
            Valide además que el mes sea un numero entre 1 y 12 de lo contrario
            imprima mes no valido.*/
            try
            {
                int m, a;
                Console.Write("Digite el mes: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Digite el año: ");
                a = int.Parse(Console.ReadLine());

                if( m >= 1 && m <= 12)
                {
                    //OR tambien es utilizado para listas de seleccion cuando hay casos en comun
                    if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) Console.WriteLine("31 dias");
                    if (m == 4 || m == 6 || m == 9 || m == 11) Console.WriteLine("30 dias");
                    if (m == 2)
                    {
                        if(a%4 == 0)
                            Console.WriteLine("29 días"); //bisiesto.
                        else
                            Console.WriteLine("28 días");
                    }
                }
                else
                    Console.WriteLine("Mes debe estar entre 1 y 12.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros enteros.");
            }
        }
    }
}
