namespace _18_estructura_if_and
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se da un descuento por venta, se captura el monto de la venta.
            Si la venta es mayor o igual a 2000 se da un 10% de descuento
            Si la venta es mayor o igual a 5000 se da un 20% de descuento
            Si la venta es mayor o igual a 10000 se da un 30% de descuento
            Si la venta es mayor o igual a 20000 se da un 50% de descuento
            Hacer un programa que imprima el valor del descuento y el valor a pagar
            -> Resuelvalo utilizando operadores logicos.*/
            try
            {
                float monto, descuento = 0;
                Console.Write("Digite el monto de lo vendido:");
                monto = float.Parse(Console.ReadLine());

                //AND es muy util para definir rangos numericos
                if (monto >= 2000 && monto < 5000) descuento = monto * 0.10f;
                if (monto >= 5000 && monto < 10000) descuento = monto * 0.20f;
                if (monto >= 10000 && monto < 20000) descuento = monto * 0.30f;
                if (monto >= 20000) descuento = monto * 0.50f;

                Console.WriteLine($"El descuento es: {descuento}");
                Console.WriteLine($"El total a pagar es: {monto-descuento}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Debe digitar unicamente numeros");
            }
        }
    }
}
