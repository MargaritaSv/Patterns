using System.Collections.Generic;

namespace AbstrackFactory.Pizzas
{
    public class Calcone : Pizza
    {
        private readonly string madeBy;

        public Calcone(IEnumerable<string> ingredians, string madeBy)
            : base(ingredians)
        {
            this.madeBy = madeBy;
        }

        protected override string Name
        {
            get
            {
                return string.Format($"Calzone is made from {this.madeBy}");
            }
        }
    }
}