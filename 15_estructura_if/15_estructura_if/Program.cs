namespace _15_estructura_if
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
            Hacer un programa que imprima el valor del descuento y el valor a pagar*/
            try
            {
                float monto, descuento = 0;
                Console.Write("Digite el monto de lo vendido: ");
                monto = float.Parse(Console.ReadLine());

                //usando puro if sin else
                //esto funciona; pero no es eficiente ya que calcula todo
                //por ejemplo si vende 20000 entonces hace 4 calculos
                //esta solucion es menos eficiente que la del ejemplo anterior
                if (monto >= 2000) descuento = monto * 0.10f;
                if (monto >= 5000) descuento = monto * 0.20f;
                if (monto >= 10000) descuento = monto * 0.30f;
                if (monto >= 20000) descuento = monto * 0.50f;

                Console.WriteLine($"Descuento: {descuento}");
                Console.WriteLine($"Pagar: {monto - descuento}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Solo se admite numeros");
            }
        }
    }
}
