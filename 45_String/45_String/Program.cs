namespace _45_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Capturar un string a traves de la consola/terminal
            Console.Write("Digite un string: ");
            string str = Console.ReadLine();

            Console.WriteLine($"string leido {str}");
            Console.WriteLine($"Longitud: {str.Length}");
            Console.WriteLine($"todo en mayusculas: {str.ToUpper()}");
            Console.WriteLine($"todo en minusculas: {str.ToLower()}");
            Console.WriteLine($"sin relleno de espacios: {str.Trim()}");
            Console.WriteLine($"Longitud sin relleno: {str.Trim().Length}");

            /*Ejercicio: pregunte al usuario un string, luego hara
             una copia de dicho string en una nueva variable.
            A dicha copia le van a reemplazar las letras A por 4,
            las letras E por 3, las letras I por 1.
            -> Ignoraran mayusculas y minusculas en reemplazo de la A, E, I.
            -> Las tildes no cuentan en este ejercicio
            -> Se le prohibe usar el metodo Replace, Expresiones reguales
               o cualquier otro metodo de reemplazado que no sea caracter
               por caracter.
            Ejemplo:
            Digite un string: Manzana VerdE
            Resultado: M4nz4n4 V3rd3
            */
            Console.Write("Digite un string: ");
            string texto = Console.ReadLine();
            string copia = "";

            //forma 1: comparando el caracter en mayusc. y minusc.
            for (int i = 0; i < texto.Length; i++)
            {
                if(texto[i] == 'A' || texto[i] == 'a')
                    copia = copia + '4';
                else
                {
                    if (texto[i] == 'E' || texto[i] == 'e')
                        copia = copia + '3';
                    else
                    {
                        if (texto[i] == 'I' || texto[i] == 'i')
                            copia = copia + '1';
                        else
                            copia = copia + texto[i];
                    }
                }
            }
            Console.WriteLine($"Resultado: {copia}");

            //forma 2: comparando el caracter solo en mayusc. a partir de la copia en mayusc.
            copia = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto.ToUpper()[i] == 'A')
                    copia = copia + '4';
                else
                {
                    if (texto.ToUpper()[i] == 'E')
                        copia = copia + '3';
                    else
                    {
                        if (texto.ToUpper()[i] == 'I')
                            copia = copia + '1';
                        else
                            copia = copia + texto[i];
                    }
                }
            }
            Console.WriteLine($"Resultado: {copia}");
        }
    }
}
