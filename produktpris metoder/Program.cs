
namespace produktpris_metoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product calculator");
            Console.WriteLine("How many products do you wanna buy?");
            var totalProducts = int.Parse(Console.ReadLine());
            Console.WriteLine("How much does one product cost?");
            var productPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("how much is the VAT in percent?");
            var vat = double.Parse(Console.ReadLine());

            var totalPrice = CalculatePrice(totalProducts, productPrice, vat);
            Console.WriteLine($"The total price inc. VAT is:{totalPrice} SEK");
        }

        private static double CalculatePrice(
            int totalProducts, 
            int productPrice, 
            double vat)
        {
            var totalPrice = (totalProducts)*(productPrice
        }
    }
}
