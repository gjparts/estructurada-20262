namespace _34_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que capture N cantidad de edades de personas.
            -> El programa termina cuando se digite una edad menor que cero.
            -> Una vez termine el programa debe imprimir una tabla que resuma
               cuantas edades se leyeron por grupo de edad de acuerdo a la escala
               siguiente:

               de 0 a menos de 18	menores de edad
               de 18 a menos de 21  mayores de edad
               de 21 a menos de 60  adultos
               de 60 en adelante	tercera edad*/
            try
            {
                int edad = 0; //variable bandera
                int menores = 0, mayores = 0, adultos = 0, tercera = 0; //acumuladores

                while (edad >= 0)
                {
                    Console.Write("Digite una edad: ");
                    edad = int.Parse(Console.ReadLine());

                    //clasificar la informacion
                    if (edad >= 0 && edad < 18) menores++; //menores = menores + 1;
                    if (edad >= 18 && edad < 21) mayores++;
                    if (edad >= 21 && edad < 60) adultos++;
                    if (edad >= 60) tercera++;
                }
                //sumario:
                Console.WriteLine($"Menores de edad: {menores}");
                Console.WriteLine($"Mayores de edad: {mayores}");
                Console.WriteLine($"Adultos: {adultos}");
                Console.WriteLine($"Tercera edad: {tercera}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se permite numeros enteros.");
            }
        }
    }
}
