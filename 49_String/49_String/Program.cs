namespace _49_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Metodo Split
            Devuelve un arreglo de elementos String el cual es resultado
            de dividir en partes otro String a traves de un delimitador (token).*/
            String colores = "Rojo,Verde,Azul,Blanco,Gris,Amarillo,Celeste,Naranja";
            Console.WriteLine($"String de colores: {colores}");

            string[] arreglo1; //arreglo de String sin inicializar

            //inicializar arreglo1 con el resultado del Split al String de colores
            arreglo1 = colores.Split(","); //la coma sera el delimitador

            //imprimir arreglo1:
            for(int i = 0; i < arreglo1.Length; i++)
                Console.WriteLine(arreglo1[i]);

            Console.WriteLine("**************************");

            //el token puede ser cualquier String
            string carro = "ToyotaSEPARADORCorollaSEPARADOR2012SEPARADORNegro";
            string[] arreglo2 = carro.Split("SEPARADOR");

            //imprimir arreglo2:
            for (int i = 0; i < arreglo2.Length; i++)
                Console.WriteLine(arreglo2[i]);

            Console.WriteLine("**************************");

            //que pasaria si un string viene con caracteres como \
            string datos = "sandia\\naranja\\fresa\\melon";
            string[] arreglo3 = datos.Split("\\");

            //imprimir arreglo3:
            for (int i = 0; i < arreglo3.Length; i++)
                Console.WriteLine(arreglo3[i]);

            Console.WriteLine("**************************");

            //Contar palabras usando Split
            /*Haga un programa que pregunte un String, luego deben decir
             cuantas palabras tiene el String digitado.
            -> Resuelvalo usando el metodo Split*/
            Console.Write("Digite una oracion: ");
            string oracion = Console.ReadLine();

            string[] arreglo4 = oracion.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            //el segundo parametro permite ignorar aquellos elementos del arreglo
            //que quedaron con string de espacios vacio

            Console.WriteLine($"Cantidad de palabras: {arreglo4.Length}");
            //el numero de palabras es la cantidad de elementos que dejo Split en el arreglo4
        }
    }
}
