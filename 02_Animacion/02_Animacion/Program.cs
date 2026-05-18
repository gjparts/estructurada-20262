namespace _02_Animacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //estructura for la veremos mas adelante
            for(int i = 1; i <= 50; i++)
            {
                //imprimir peces
                Console.SetCursorPosition(i, 5);
                Console.WriteLine("><>");
                Console.SetCursorPosition(i+7, 19);
                Console.WriteLine("><>");
                Console.SetCursorPosition(i+5, 13);
                Console.WriteLine("><>");

                //hacer una pausa de 50 milisegundos
                Thread.Sleep(50);

                //Limpiar la terminal
                Console.Clear();
            }
        }
    }
}
