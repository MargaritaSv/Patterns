using System.Collections.Generic;

namespace AbstrackFactory.Pizzas
{
    public class Piperony : Pizza
    {
        private readonly string madeBy;

        public Piperony(IEnumerable<string> ingrediants, string madeBy)
            : base(ingrediants)
        {
            this.madeBy = madeBy;
        }

        protected override string Name
        {
            get
            {
                return string.Format($"Piperony is madefrom {this.madeBy}");
            }
        }
    }
}
