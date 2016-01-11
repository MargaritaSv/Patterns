using AbstrackFactory.Factories;
using System;

namespace AbstrackFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaPlace = new AlfredoPlace();
            var mamamiq = new OnlineDelivery(pizzaPlace);

            var cheesePizza = mamamiq.DeliveryCalconePizza();
            Console.WriteLine(cheesePizza);

            var pizzaPlace1 = new DonDomatRestaurant();
            var bellisimo = new OnlineDelivery(pizzaPlace1);

            var seaPizza = bellisimo.DeliverySeaPizza();
            Console.WriteLine(seaPizza);
        }
    }
}
