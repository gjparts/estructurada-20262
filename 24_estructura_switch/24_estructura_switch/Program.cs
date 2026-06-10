namespace _24_estructura_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que pregunte el mes y el año.
             El programa va a imprimir cuántos días tiene el mes/año digitado.
            Si digita un mes que no esta entre 1 y 12 entonces imprima: mes no valido.
            -> Resuelvado sin utilizar if, sino usando switch.
            -> Unicamente puede usar if para evaluar Febrero.*/
            try
            {
                int m, a;
                Console.Write("Digite el numero de mes: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Digite el año: ");
                a = int.Parse(Console.ReadLine());

                //cuando tiene casos con resultados en comun
                //puede desencadenarlos de la siguiente forma:
                switch (m)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("31 días");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("30 días");
                        break;
                    case 2:
                        if (a % 4 == 0)
                            Console.WriteLine("29 días");
                        else
                            Console.WriteLine("28 días");
                        break;
                    default:
                        Console.WriteLine("Mes no valido");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros enteros.");
            }
        }
    }
}
