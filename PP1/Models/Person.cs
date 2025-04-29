using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1
{
    public class Person
    {
        
        public string FirstName;
        public string SecondName;

        //public string FirstName;
        //public string SecondName;
        //public string ParticipationFormat;
        //public string ParticipationSection;
        //public List<string> AdditionalServices;

        //public bool isAdded = false;
        //public Participant(string fio,  List<string> aservices)
        //{
        //    FIO = fio;
        //    ParticipationFormat = pformat;
        //    ParticipationSection = psection;
        //    AdditionalServices = aservices;
        //}
        //public string SerializeObject()
        //{
        //    string listSer = "[";
        //    for (int i = 0; i < AdditionalServices.Count; i++)
        //    {
        //        listSer += AdditionalServices[i];
        //        if (i != AdditionalServices.Count - 1)
        //        {
        //            listSer += ", ";
        //        }
        //    }
        //    listSer += "]";
        //    return $"{this.FIO}, {this.ParticipationFormat.ToLower()}, \"{ParticipationSection}\", {listSer}";
        //}


        public Person(string fname, string sname)
        {
            this.FirstName = fname.Trim();
            this.SecondName = sname.Trim();
        }
    }
}
