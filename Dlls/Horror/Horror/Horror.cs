using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Books.Fictions
{
    class Horror : Fiction
    {
        public string Age { get; set; }
        public bool Psyhological { get; set; }

        public Horror() { }

        public Horror(Fiction f) : base(f) { }

        public Horror(Horror t) : base(t)
        {
            this.Age = t.Age;
            this.Psyhological = t.Psyhological;
        }
    }
}
