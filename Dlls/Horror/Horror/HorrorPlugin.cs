using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_4.Loaders.FictionsLoaders;
using Lab_4.Books.Fictions;
using Lab_4.Helpers;

namespace Lab_4
{
    public class HorrorPlugin : IPlugin
    {
        Horror book = new Horror();
        string bookType = "Horror";
        string parentType = "Fiction";

        public Hierarchy GetHierarchy()
        {
            return new Hierarchy(new HorrorLoader(), new List<string>());
        }
    }
}
