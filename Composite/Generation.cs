using System;

namespace Composite
{
    public class Generation : GenerationComponent
    {
        public Generation(string name)
            : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);
        }
    }
}
