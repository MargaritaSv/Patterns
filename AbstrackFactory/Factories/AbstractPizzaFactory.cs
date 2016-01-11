using AbstrackFactory.Pizzas;

namespace AbstrackFactory.Factories
{
    public abstract class AbstractPizzaFactory
    {
        public abstract Calcone MakeCalcone();

        public abstract Piperony MakePiperony();

        public abstract SeaPizza MakeSeaPizza();
    }
}
