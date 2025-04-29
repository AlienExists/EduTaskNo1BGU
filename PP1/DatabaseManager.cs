using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PP1.Models;
using System.Windows.Forms;
using System.Data;

namespace PP1
{
    public class DatabaseManager
    {
        private string connectionString = @"Data Source=localhost;Initial Catalog=Conferentions;Integrated Security=True";


        public int? sectionSearch(string sectionName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand($"select id from ParticipationSection where name = '{sectionName}'", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return (int)reader["id"];
                    }
                }
                return null;
            }

        }

        public List<int> searchCheckedServices(List<string> services)
        {
            List<int> ids = new List<int>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach(string item in services)
                {
                    var cmd = new SqlCommand($"SELECT id FROM AdditionalServices WHERE name = '{item}'", conn);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            ids.Add((int)reader["id"]);
                        }
                    }
                }
            }


            return ids;
        }

        public void updateAdditionalServices(int regId, List<int>servIds)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Registrations_Services WHERE registrations_id = @regId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@regId", regId);
                cmd.ExecuteNonQuery();
                string query = "";
                foreach(int id in servIds)
                {
                    query += $"INSERT INTO Registrations_Services (services_id, registrations_id) VALUES ({id}, {regId})";
                }
                var cmd2 = new SqlCommand(query, conn);
                cmd2.ExecuteNonQuery();

            }
        }

        public List<Conferention> getConferentions()
        {
            List<Conferention> conferentions = new List<Conferention>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id, name, date, format FROM Conferentions", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if(DateTime.Now < DateTime.Parse(reader["date"].ToString()))
                        {
                            conferentions.Add(new Conferention((int)reader["id"], reader["name"].ToString(), DateTime.Parse(reader["date"].ToString()), bool.Parse(reader["format"].ToString())));
                        }
                    }
                }
            }
            return conferentions;
        }

        public List<Service> getAdditionalServices()
        {
            List<Service> services = new List<Service>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id, name FROM AdditionalServices", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        services.Add(new Service((int)reader["id"], reader["name"].ToString()));
                        
                    }
                }
            }
            return services;
        }

        public List<Section> getSections()
        {
            List<Section> sections = new List<Section>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id, name FROM ParticipationSection", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        sections.Add(new Section((int)reader["id"], reader["name"].ToString()));

                    }
                }
            }
            return sections;
        }

        public List<Person> getPersons()
        {
            List<Person> persons = new List<Person>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT first_name, second_name FROM Persons", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        persons.Add(new Person(reader["first_name"].ToString(), reader["second_name"].ToString()));

                    }
                }
            }
            return persons;
        }

        public int searchPerson(Person person)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string search = $"SELECT * FROM PERSONS WHERE first_name = N'{person.FirstName}' AND second_name = N'{person.SecondName}'";

                SqlCommand cmd = new SqlCommand(search, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return (int)reader["id"];
                    }
                    else return -1;

                }
            }
            
        }

        


        public int addNewPerson(Person person)
        {
            if (searchPerson(person) == -1)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string addPerson = $"INSERT INTO PERSONS (first_name, second_name) values (N'{person.FirstName}', N'{person.SecondName}')";


                    var cmd = new SqlCommand(addPerson, conn);
                    cmd.ExecuteNonQuery();



                }
                return searchPerson(person);
            }
            return searchPerson(person);
            
        }

        public void createRegistration(int personID, int conferentionID, int? sectionID, List<int> aservicesID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                
                SqlCommand searcher = new SqlCommand($"SELECT MAX(id) from Registrations", conn);
                int registrationID = int.Parse(searcher.ExecuteScalar().ToString()) + 1;

                string addReg = $"INSERT INTO Registrations (person_id, psection_id, registration_date, conferention_id) values ({personID}, {sectionID}, '{DateTime.Now}', {conferentionID})";

                foreach (int aserviceID in aservicesID)
                {
                    addReg += $"INSERT INTO Registrations_Services (services_id, registrations_id) values ({aserviceID}, {registrationID})";
                }

                var cmd = new SqlCommand(addReg, conn);
                cmd.ExecuteNonQuery();



            }
        }

        //public List<Registration> getRegistrations()
        //{
        //    List<Registration> registrations = new List<Registration>();

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("SELECT Registrations.id, Persons.first_name, Persons.second_name, ParticipationSection.name as pname, registration_date, Conferentions.name as confname FROM Registrations JOIN Persons ON Registrations.person_id = Persons.id JOIN Conferentions ON Registrations.conferention_id = Conferentions.id JOIN ParticipationSection ON Registrations.psection_id = ParticipationSection.id JOIN Registrations_Services ON Registrations_Services.registrations_id = Registrations.id", conn);
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                registrations.Add(new Registration((int)reader["id"], reader["first_name"].ToString(), reader["second_name"].ToString(), reader["pname"].ToString(), reader["registration_date"].ToString(), reader["confname"].ToString()));
        //            }
        //        }
        //    }
        //    return registrations;
        //}

        public DataTable getRegistrations()
        {
            string query = @"SELECT Registrations.id, Conferentions.id as idconf, ParticipationSection.id as idpsect, Persons.first_name as Имя, Persons.second_name as Фамилия, Conferentions.name as Конференция, ParticipationSection.name as Секция, STRING_AGG(AdditionalServices.name, ', ') AS Доп
FROM Registrations JOIN 
Conferentions ON Registrations.conferention_id = Conferentions.id
JOIN
Persons  ON Registrations.person_id = Persons.id
JOIN
ParticipationSection ON Registrations.psection_id = ParticipationSection.id
LEFT JOIN
Registrations_Services ON Registrations_Services.registrations_id = Registrations.id
LEFT JOIN 
AdditionalServices ON Registrations_Services.services_id = AdditionalServices.id 
GROUP BY Registrations.id, Conferentions.id, ParticipationSection.id, Persons.first_name, Persons.second_name, Conferentions.name, ParticipationSection.name";
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                
                adapter.Fill(table);
            }
            return table;
        }
            
        public void updateReg(int regId, int confId, int sectId, Person person)
        {
            int personId = addNewPerson(person);

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE Registrations
   SET [person_id] = @personId
      ,[psection_id] = @sectId
      ,[conferention_id] = @confId
 WHERE id = @regId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@personId", personId);
                cmd.Parameters.AddWithValue("@sectId", sectId);
                cmd.Parameters.AddWithValue("@confId", confId);
                cmd.Parameters.AddWithValue("@regId", regId);
                cmd.ExecuteNonQuery();
            }

        }

        public void deleteReg(int regId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Registrations_Services WHERE registrations_id = @regId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@regId", regId);
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"DELETE FROM Registrations WHERE id = @regId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@regId", regId);
                cmd.ExecuteNonQuery();
            }
            
        }

    }
}
