using System.Collections.Generic;
using AbstrackFactory.Pizzas;

namespace AbstrackFactory.Factories
{
    public class AlfredoPlace : AbstractPizzaFactory
    {
        private readonly string Name = "Alfredo Torres place.";

        public override Calcone MakeCalcone()
        {
            var ingrediants = new List<string> {"tomatoes",
                                      "white cheese",
                                      "yellow cheese",
                                      "blue cheese",
                                      "extra smelly cheese" };

            var pizza = new Calcone(ingrediants, this.Name);
            return pizza;
        }

        public override Piperony MakePiperony()
        {
            var products = new List<string> { "hot peper", "chili", "tomatos", "green hot pepers" };
            var pizza = new Piperony(products, this.Name);

            return pizza;
        }

        public override SeaPizza MakeSeaPizza()
        {
            var products = new List<string> { "crab rolls", "salmon", "carrot", "peas", "pieces of crap" };
            var pizza = new SeaPizza(products, this.Name);

            return pizza;
        }
    }
}
