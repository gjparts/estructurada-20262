namespace _35_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un menú en pantalla que muestre las opciones siguientes:

            ------ MENU ------
            1) Saludame
            2) Dime la fecha y hora
            3) Cuentame un chiste
            4) Reproduce un sonido
            5) Quiero que me ayudes a sumar dos numeros
            6) Salir

            -> Programe algo relacionado para cada acción, el programa no debe
               terminar hasta que elija la opcion 6.
            -> Debe limpiar la pantalla antes de mostrar el menu
            -> Cuando se digite un numero de opcion se debera volver a mostrar el menu
               excepto cuando se digite la opcion 6, ya que este termina con el programa.
*/

            int opcion;
            do
            {
                try
                {
                    Console.Clear(); //limpieza de pantalla
                    Console.WriteLine("------ MENU ------");
                    Console.WriteLine("1) Saludame");
                    Console.WriteLine("2) Dime la fecha y hora");
                    Console.WriteLine("3) Cuentame un chiste");
                    Console.WriteLine("4) Reproduce un sonido");
                    Console.WriteLine("5) Quiero que me ayudes a sumar dos numeros");
                    Console.WriteLine("6) Salir");
                    Console.Write("Digite el numero de opcion deseado: ");
                    opcion = int.Parse(Console.ReadLine());

                    //las variables que use dentro de switch es recomendado
                    //declararlas fuera de él
                    double a, b;

                    //acciones
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Hola como estas!");
                            break;
                        case 2:
                            Console.WriteLine($"Hoy es: {DateTime.Now}");
                            break;
                        case 3:
                            Console.WriteLine("Soy una maquina no se chistes.");
                            break;
                        case 4:
                            Console.Beep(1000, 2000); //1000 Hertz durante 2 segundos
                            Console.Beep(500, 1000); //500 Hertz durante un segundo
                            break;
                        case 5:
                            Console.Write("Digite a: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Digite b: ");
                            b = double.Parse(Console.ReadLine());
                            Console.WriteLine($"La suma es {a+b}");
                            break;
                        case 6:
                            Console.WriteLine("Adios");
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                    Console.WriteLine("Presiona cualquier tecla para volver al menu.");
                    Console.ReadKey(false);//hacer una pausa
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Numero digitado no valido.");
                    opcion = 0; //en caso de error debe haber al menos un valor en opcion
                }
            } while (opcion != 6);
        }
    }
}
