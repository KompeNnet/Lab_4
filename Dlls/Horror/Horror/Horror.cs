namespace Lab_4.Books.Fictions
{
    public class Horror : Fiction
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
