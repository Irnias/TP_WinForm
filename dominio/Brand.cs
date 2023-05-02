namespace domain
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
