namespace _36_for_anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura anidada (Nested)
            Es una estructura que está dentro de otra estructura, por ejemplo
            -> un if que esta dentro de otro if
            -> un switch que esta dentro de un do-while
            -> un for dentro de otro
            -> un if dentro un for
            -> un for dentro de un if
            
            Cuando Usted tiene una estructura de repeticion dentro de otra
            estructura de repeticion normalmente ocurre porque ocupa
            iterar tantas veces como ha iterado en la estructura de repeticion
            que envuelve a la otra.
            Para que se hagan una idea es como imprimir un rectangulo
            Por cada renglon (bucle principal) van a imprimir N cantidad
            de columnas (bucle secundario).

            Ejemplo, haga un programa que pregunte al usuario el alto y ancho
            de un rectangulo. Luego el programa va a imprimir dicho rectangulo
            compuesto por simbolos asterisco.
             */
            try
            {
                int alto, ancho;
                Console.Write("Digite la altura: ");
                alto = int.Parse(Console.ReadLine());
                Console.Write("Digite el ancho: ");
                ancho = int.Parse(Console.ReadLine());

                for(int i = 1; i <= alto; i++) //bucle principal (renglon por renglon)
                {
                    for(int j = 1;  j <= ancho; j++) //bucle secundario (cada columna)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); //pasar a la linea siguiente
                }

                int altura;
                Console.Write("Digite la altura:");
                altura = int.Parse(Console.ReadLine());

                for(int i = 1; i <= altura; i++) //principal
                {
                    for(int j = 1; j <= i; j++) //secundaria (en este caso depende de i)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); //nuevo renglon
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se acepta numeros enteros.");
            }
        }
    }
}
