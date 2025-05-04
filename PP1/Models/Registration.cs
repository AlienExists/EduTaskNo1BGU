namespace PP1.Models
{
    public class Registration
    {
        public int id;
        public string first_name;
        public string second_name;
        public string pformat;
        public string registration_date;
        public string conferention;


        public Registration(int id, string first_name, string second_name, string pformat, string registration_date, string conferention)
        {
            this.id = id;
            this.first_name = first_name;
            this.second_name = second_name;
            this.pformat = pformat;
            this.registration_date = registration_date;
            this.conferention = conferention;
        }
    }
}
