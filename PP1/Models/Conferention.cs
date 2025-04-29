using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1
{
    public class Conferention
    {
        public int id { get; }
        public string name { get; }
        public DateTime date { get; }
        public bool format { get; }



        public Conferention(int id, string name, DateTime date , bool format)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.format = format;
        }
    }
}
