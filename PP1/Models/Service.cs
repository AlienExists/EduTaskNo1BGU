namespace PP1.Models
{
    public class Service
    {
        public int id { get; set; }
        public string name { get; set; }

        public Service(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
