namespace Lab_4.Books.Fictions
{
    public class Horror : Fiction
    {
        public string Age { get; set; }
        public bool IsPsyhological { get; set; }

        public Horror() { }

        public Horror(Fiction f) : base(f) { }

        public Horror(Horror t) : base(t)
        {
            this.Age = t.Age;
            this.IsPsyhological = t.IsPsyhological;
        }
    }
}
