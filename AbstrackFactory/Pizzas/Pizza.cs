using System.Collections.Generic;
using System.Text;

namespace AbstrackFactory.Pizzas
{
    public abstract class Pizza
    {
        private readonly IReadOnlyCollection<string> ingredients;

        protected Pizza(IEnumerable<string> ingredients)
        {
            this.ingredients = new List<string>(ingredients);
        }

        protected abstract string Name { get; }

        public IEnumerable<string> Ingredient
        {
            get { return this.ingredients; }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name).AppendLine(string.Join(", ", this.Ingredient));
            return sb.ToString();
        }
    }
}
