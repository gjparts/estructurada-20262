using System.Text.RegularExpressions;

namespace _51_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Método Replace
            Devuelve una copia del string a la que se le ha reemplazado
            todas las coincidencias encontradas de otro string.
            -> Este metodo no ignora mayusc./minusc. de forma tradicional*/
            string frase = "Verde es la Manzana, la manzana es verde. Que verde es la manzana!";
            Console.WriteLine(frase);

            //reemplazar verde por roja sin alterar el string original, imprimir el resultado
            Console.WriteLine(frase.Replace("verde","roja"));
            //verifiquemos si se altero el string original?
            Console.WriteLine(frase);
            //si quiere alterar el string original:
            frase = frase.Replace("verde","roja");
            //verifiquemos si se altero el string original?
            Console.WriteLine(frase);

            //Tambien es posible desencadenar varios Replace en una sola instruccion:
            string texto = "La naranja es una buena fruta, el jugo de naranja es mejor que el de noni";
            //reemplazar naranja por melon y reemplazar noni por aloe alterando el string original
            texto = texto.Replace("naranja", "melon").Replace("noni","aloe");
            Console.WriteLine(texto);

            //Usar Replace pero ignorando mayusculas y minusculas
            string colores = "Rojo ROJO ROJo RoJo AZUL AZul azul AzUL VERde VERDE verde VERdE";
            //reemplazar azul por celeste ignorando mayusculas y minusculas alterando el string original
            //vamos a ocupar una clase llamada Regex usada para aplicacion de expresiones regulares
            colores = Regex.Replace(colores, "azul", "celeste", RegexOptions.IgnoreCase);
            Console.WriteLine(colores);

            /*Pregunte un string al usuario, luego reemplace en dicho string los
             espacios en blanco por guiones bajos, la letras E por numeros 3, las
             letras I por numeros 1.
            -> debera ignorar mayusculas/minusculas.
            -> imprima el string modificado*/
            Console.Write("Digite un string: ");
            string algo = Console.ReadLine();

            //forma 1:
            //algo = algo.Replace(" ", "_").Replace("E","3").Replace("e","3").Replace("I", "1").Replace("i", "1");

            //forma 2:
            algo = algo.Replace(" ", "_");
            algo = Regex.Replace(algo, "E", "3", RegexOptions.IgnoreCase);
            algo = Regex.Replace(algo, "I", "1", RegexOptions.IgnoreCase);
            Console.WriteLine($"Resultado: {algo}");
        }
    }
}
