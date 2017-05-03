using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Lab_4.Books;
using Lab_4.Books.Fictions;
using Lab_4.Helpers;

namespace Lab_4.Loaders.FictionsLoaders
{
    public class HorrorLoader : FictionLoader
    {
        public override dynamic Create(GroupBox g)
        {
            Horror t = new Horror(base.Create(g));

            GroupBox horrorGroupBox = ((Grid)g.Content).Children.OfType<GroupBox>().First(x => x.Name == "FictHorrorGroup");
            IEnumerable<TextBox> tbList = ((Grid)horrorGroupBox.Content).Children.OfType<TextBox>();

            t.Age = tbList.First(x => x.Name == "InpFictHorrAge").Text;
            
            IEnumerable<CheckBox> cbList = ((Grid)horrorGroupBox.Content).Children.OfType<CheckBox>();

            t.Psyhological = cbList.First(x => x.Name == "CheckFictHorrIsPsychologacal").IsChecked.Value;
            return t;
        }

        public override dynamic BaseCreate(GroupBox g)
        {
            return new Horror(base.Create(g));
        }

        public override Grid Load(dynamic h)
        {
            Grid g = base.Load((Fiction)h);

            Grid grg = FormCreator.CreateGrid(new Thickness(0, 0, 0, 0));
            grg.Children.Add(FormCreator.CreateLabel("Age limit", new Thickness(10, 10, 73, 0)));
            grg.Children.Add(FormCreator.CreateTextBox("InpFictHorrAge", h.Countries, new Thickness(10, 38, 10, 0)));

            grg.Children.Add(FormCreator.CreateCheckBox("CheckFictHorrIsPsychological", "is Psychological", new Thickness(10, 88, 10, 0), h.IsEarth));

            GroupBox gr = FormCreator.CreateGroupBox("FictHorrorGroup", "Horror", new Thickness(329, 0, 10, 10), 174, 384);
            gr.Content = grg;

            g.Children.Add(gr);

            GroupBox fictionGroupBox = g.Children.OfType<GroupBox>().First(x => x.Name == "FictionGroup");
            IEnumerable<ComboBox> cbList = ((Grid)fictionGroupBox.Content).Children.OfType<ComboBox>();
            ComboBox genreComboBox = cbList.First(x => x.Name == "ChooseFictType");
            genreComboBox.SelectedIndex = 1;

            return g;
        }

        public override dynamic Deserialize(dynamic d)
        {
            return Serializer.Deserialize<Horror>(d);
        }
    }
}
