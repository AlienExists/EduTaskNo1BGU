namespace PP1.Models
{
    public class Section
    {
        public int id { get; set; }
        public string name { get; set; }

        public Section(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
