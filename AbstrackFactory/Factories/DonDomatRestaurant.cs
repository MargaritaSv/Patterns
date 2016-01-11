using System.Collections.Generic;
using AbstrackFactory.Pizzas;

namespace AbstrackFactory.Factories
{
    public class DonDomatRestaurant : AbstractPizzaFactory
    {
        private readonly string Name = "Don Domat restaurant ";

        public override Calcone MakeCalcone()
        {
            var products = new List<string> { "tomatos", "filet", "yellow cheese", "white cheese" };
            var pizza = new Calcone(products, this.Name);

            return pizza;
        }

        public override Piperony MakePiperony()
        {
            var products = new List<string> { "suprices especially for the clients" };
            var pizza = new Piperony(products, this.Name);

            return pizza;
        }

        public override SeaPizza MakeSeaPizza()
        {
            var products = new List<string> { "suprices with seafood especially for the clients" };
            var pizza = new SeaPizza(products, this.Name);

            return pizza;
        }
    }
}
