using System;
using System.Collections.Generic;

namespace Composite
{
    public class GreekGod : GenerationComponent
    {

        private readonly ICollection<GenerationComponent> subject;

        public GreekGod(string name)
            : base(name)
        {
            this.subject = new List<GenerationComponent>();
        }

        public void Add(GenerationComponent person)
        {
            this.subject.Add(person);
        }

        public void Remove(GenerationComponent person)
        {
            this.subject.Remove(person);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);

            foreach (var person in this.subject)
            {
                person.Display(depth + 4);
            }
        }
    }
}
