namespace _11_estructura_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En una tienda se otorga un descuento de acuerdo
            al monto de lo vendido.
            Si el monto es mayor de 10000; entonces damos
            un descuento del 20% sobre el valor de dicho monto,
            de lo contrario no hay descuento.
            Capture el monto vendido e imprima el valor del 
            descuento y el valor que el cliente tiene que pagar.*/
            
            //Lo resolveremos usando if-else:
            float monto, descuento, pagar;

            Console.Write("Digite el monto de lo vendido: ");
            monto = float.Parse(Console.ReadLine());

            if (monto > 10000)
                descuento = monto * 0.20f;
            else
                descuento = 0;

            pagar = monto - descuento;
            Console.WriteLine($"Descuento: {descuento}");
            Console.WriteLine($"Total a pagar: {pagar}");
        }
    }
}
