using AbstrackFactory.Factories;
using AbstrackFactory.Pizzas;

namespace AbstrackFactory
{
    public class OnlineDelivery
    {
        private readonly AbstractPizzaFactory factory;

        public OnlineDelivery(AbstractPizzaFactory pizzaFactory)
        {
            this.factory = pizzaFactory;
        }

        public Calcone DeliveryCalconePizza()
        {
            return this.factory.MakeCalcone();
        }

        public Piperony DeliveryPiperonyPizza()
        {
            return this.factory.MakePiperony();
        }

        public SeaPizza DeliverySeaPizza()
        {
            return this.factory.MakeSeaPizza();
        }
    }
}
