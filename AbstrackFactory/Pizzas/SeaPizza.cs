using System.Collections.Generic;

namespace AbstrackFactory.Pizzas
{
    public class SeaPizza : Pizza
    {
        private readonly string madeBy;

        public SeaPizza(IEnumerable<string> ingredians, string madeBy)
            : base(ingredians)
        {
            this.madeBy = madeBy;
        }

        protected override string Name
        {
            get
            {
                return string.Format($"Sea pizza is made from {this.madeBy}");
            }
        }
    }
}
