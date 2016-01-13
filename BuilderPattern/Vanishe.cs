using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Vanishe
    {
        private readonly string vanisheType;

        private readonly Dictionary<string, string> parts = new Dictionary<string, string>();

        public Vanishe(string vanishType)
        {
            this.vanisheType = vanisheType;
        }

        public string this[string key]
        {
            get { return this.parts[key]; }
            set { this.parts[key] = value; }
        }

        public void Slow()
        {
           //TODO:
        }
    }
}
