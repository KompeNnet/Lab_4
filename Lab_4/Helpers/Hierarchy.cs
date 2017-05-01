using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_4.Loaders;

namespace Lab_4.Helpers
{
    class Hierarchy
    {
        public List<string> BookChild { get; set; }
        internal BookLoader Loader { get; set; }

        public Hierarchy(BookLoader loader, List<string> bookChild)
        {
            this.BookChild = bookChild;
            this.Loader = loader;
        }
    } 
}
