namespace Composite
{
    public abstract class GenerationComponent
    {
        protected GenerationComponent(string name)
        {
            this.Name = name;
        }

        protected string Name { get; set; }

        public abstract void Display(int depth);
    }
}
