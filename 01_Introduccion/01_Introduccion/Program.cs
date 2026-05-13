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


        }
    }
}
