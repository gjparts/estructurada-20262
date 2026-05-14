namespace _01_Introduccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Comentario de una linea
            /*Comentario
             de varias
             lineas
             */
            //A los comentarios en programas se les llama: pseudocodigo

            //Imprimir texto en la terminal o consola
            //Metodo WriteLine: imprime texto en la terminal y hace una nueva linea
            Console.WriteLine("Hola UNAH");
            //tambien se puede obtener escribiendo cw y luego presione TAB
            Console.WriteLine("20012002049");
            Console.WriteLine("Gerardo Portillo");
            Console.WriteLine("Ingenieria");
            Console.WriteLine("Fin");

            //Metodo Write: imprimir texto en la terminal, no hace nueva linea
            Console.Write("Rojo");
            Console.Write("Amarillo");
            Console.Write("Azul");
            Console.Write("Verde");
            Console.Write("UNAH");

            //puede imprimir un salto de linea enviando un WriteLine en blanco
            Console.WriteLine();

            //Usar caracteres de escape
            //Caracter para nueva linea: \n
            Console.WriteLine("Linea 1\nLinea 2\nLinea 3");
            Console.WriteLine("San Pedro Sula\nCholoma\nProgreso\nPuerto Cortes");
            //hacer un salto de linea largo
            Console.WriteLine("\n\n\n\n\n\n");

            //Caracter para tabulacion: \t
            Console.WriteLine("Nombre\tEdad\tGenero");
            Console.WriteLine("Gerardo\t43\tMasculino");
            Console.WriteLine("Irene\t42\tFemenino");
            Console.WriteLine("Josue\t13\tMasculino");
            Console.WriteLine("Viena\t17\tFemenino");

            //como imprimo un slash inverso?
            Console.WriteLine("Esto es un slash inverso: \\");
            //como imprimo una comilla doble?
            Console.WriteLine("Esto es una comilla doble: \"");
            Console.WriteLine("Ramon Valdez alias \"Don Ramon\"");

            //imprimir texto RAW (sin tratamiento, crudo)
            //imprimir texto que ignora los caracteres de escape
            Console.WriteLine(@"\n\n\n\n\n");
            Console.WriteLine(@"Esto es un slash inverso: \");
            Console.WriteLine(@"Esto es una comilla doble: """);
            //el texto raw tambien permite hacer multilinea:
            Console.WriteLine(@"Linea 1
Linea 2
Linea 3
Linea 4");

            //puede usar texto raw para imprimir ASCII Art:
            Console.WriteLine(@"    .----.   @   @
   / .-""-.`.  \v/
   | | '\ \ \_/ )
 ,-\ `-.' /.'  /
'---`----'----'
");

            //Pausar la ejecucion del programa en la terminal
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true impide la impresion de la tecla

            //Limpiar la terminal
            Console.Clear();

            //Cambiar la posicion del cursor de impresion en la terminal
            //colocar el cursor en la columna 20, renglon 4
            Console.SetCursorPosition(20,4);
            Console.WriteLine("Hola");

            //ahora colocarlo en la coordenada 5,6
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("UNAH Cortes");

            //colocar texto en la coordenada 15,0
            Console.SetCursorPosition(15, 0);
            Console.WriteLine("San Pedro Sula");

            //colocar texto en la coordenada 0,20
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Gerardo Portillo");

            //Importante: el programa continuara imprimiendo
            //a partir de la ultima posicion donde dejaron 
            //el cursor en la termimal.

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //Pausar
            Console.Clear(); //Limpiar la terminal

            //usar colores en la terminal
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Texto amarillo");
            Console.WriteLine("Mas texto");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Texto Rojo");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Texto azul");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Texto amarillo sobre fondo verde oscuro");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Texto blanco sobre fondo azul oscuro");

            //Resetear los colores de la terminal a valores de fabrica
            Console.ResetColor();

            //Si desea usar multiples colores por linea, no use WriteLine
            //sino que use Write entre cada cambio de color:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Rojo");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Verde");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Amarillo");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Combinacion de color");
            Console.ResetColor();
            Console.WriteLine();


        }
    }
}
