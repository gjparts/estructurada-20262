namespace _12_estructura_if
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
            
            //lo resolveremos usando if sin else:
            float monto, descuento = 0, pagar;

            Console.Write("Digite el monto de lo vendido: ");
            monto = float.Parse(Console.ReadLine());

            //si la inicializacion del descuento es condicionado
            //entonces es necesario colocar un valor de inicio antes
            //y que no este condicionado.
            if( monto > 10000 )
                descuento = monto * 0.20f;

            pagar = monto - descuento;

            Console.WriteLine($"Descuento: {descuento}");
            Console.WriteLine($"Total a pagar: {pagar}");
        }
    }
}
