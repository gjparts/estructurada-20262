namespace _23_estructura_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura de seleccion switch
             Permite evaluar una variable y dependiendo del valor
            de esta se determinara el caso a ejecutar.
            
            Ejemplo:
            Haga un programa que pregunte un numero entero del 1 al 5, el programa
            va a imprimir como se escribe ese numero en ingles.
            Si el numero digitado no esta dentro de ese rango imprime numero desconocido.*/
            try
            {
                Console.Write("Digite un entero entre 1 y 5: ");
                int numero = int.Parse(Console.ReadLine());

                switch(numero)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        Console.WriteLine("Good luck!!");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        Console.WriteLine("Bad Luck!");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    default:
                        Console.WriteLine("Numero desconocido");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se permite numeros enteros.");
            }
        }
    }
}
