using System;

namespace ToutDeSuiteOuPlusTard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fabrice va acheter une television a credit puis une autre comptant");
            Console.WriteLine("====================================================================");
            OrderCreator VendeurDeTelevision = new OrderCreator();
            Client fabrice = new Client(1500, 1000000);
            Console.WriteLine("voici le revenu mensuel de fabrice : " + fabrice.salaireMensuel);

            VendeurDeTelevision.CreateNewOrder(PaymentType.Forward,fabrice,650);

            Console.WriteLine("voici a present les nouveaux revenus de fabrice après son achat a credit : " + fabrice.salaireMensuel);



            Console.WriteLine("voici la fortune de fabrice : " + fabrice.fortune);

            VendeurDeTelevision.CreateNewOrder(PaymentType.Spot, fabrice, 12000);

            Console.WriteLine("voici la nouvelle fortune de fabrice après son achat comptant : " + fabrice.fortune);

            Console.ReadKey();
        }
    }
}
