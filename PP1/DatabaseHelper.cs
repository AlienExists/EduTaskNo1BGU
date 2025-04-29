//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Collections.Generic;
//using проба.Models;

//namespace проба
//{
//    public class DatabaseHelper
//    {
//private string connectionString = @"Data Source=localhost;Initial Catalog=FitnessBD;Integrated Security=True";

//        public void AddClient(Client client)
//        {
//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                conn.Open();
//                var cmd = new SqlCommand("INSERT INTO Clients (client_id, name, goal_id) VALUES (@id, @name, @goal)", conn);
//                cmd.Parameters.Add("@id", SqlDbType.Int).Value = client.ClientId;
//                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = client.Name;
//                cmd.Parameters.Add("@goal", SqlDbType.Int).Value = client.GoalId;
//                cmd.ExecuteNonQuery();
//            }
//        }

//        public int GetNextClientId()
//        {
//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                conn.Open();
//                var cmd = new SqlCommand("SELECT ISNULL(MAX(client_id), 0) + 1 FROM Clients", conn);
//                return (int)cmd.ExecuteScalar();
//            }
//        }

//        public List<Client> GetAllClients()
//        {
//            var clients = new List<Client>();
//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                conn.Open();
//                var cmd = new SqlCommand("SELECT client_id, name, goal_id FROM Clients", conn);
//                using (SqlDataReader reader = cmd.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        clients.Add(new Client
//                        {
//                            ClientId = (int)reader["client_id"],
//                            Name = reader["name"].ToString(),
//                            GoalId = (int)reader["goal_id"]
//                        });
//                    }
//                }
//            }
//            return clients;
//        }

//        public DataTable GetTrainingGoals()
//        {
//            var dt = new DataTable();
//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                conn.Open();
//                var cmd = new SqlCommand("SELECT goal_id, training_goal FROM Training_Goal", conn);
//                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//                adapter.Fill(dt);
//            }
//            return dt;
//        }

//        public void UpdateClient(Client client)
//        {
//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                conn.Open();
//                var cmd = new SqlCommand(
//                    "UPDATE Clients SET name = @name, goal_id = @goal WHERE client_id = @id", conn);
//                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = client.Name;
//                cmd.Parameters.Add("@goal", SqlDbType.Int).Value = client.GoalId;
//                cmd.Parameters.Add("@id", SqlDbType.Int).Value = client.ClientId;
//                cmd.ExecuteNonQuery();
//            }
//        }

//        public void DeleteClient(int clientId)
//        {
//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                conn.Open();
//                var cmd = new SqlCommand("DELETE FROM Training WHERE client_id = @id", conn);
//                cmd.Parameters.Add("@id", SqlDbType.Int).Value = clientId;
//                cmd.ExecuteNonQuery();

//                cmd = new SqlCommand("DELETE FROM Clients WHERE client_id = @id", conn);
//                cmd.Parameters.Add("@id", SqlDbType.Int).Value = clientId;
//                cmd.ExecuteNonQuery();
//            }
//        }

//        public void AddTraining(Training training)
//        {
//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                conn.Open();
//                var cmd = new SqlCommand(
//                    "INSERT INTO Training (client_id, day_id, training_type_id) " +
//                    "VALUES (@clientId, @dayId, @typeId); SELECT SCOPE_IDENTITY();", conn);

//                cmd.Parameters.Add("@clientId", SqlDbType.Int).Value = training.ClientId;
//                cmd.Parameters.Add("@dayId", SqlDbType.Int).Value = training.DayId;
//                cmd.Parameters.Add("@typeId", SqlDbType.Int).Value = training.TrainingTypeId;

//                var result = cmd.ExecuteScalar();
//                training.TrainingId = Convert.ToInt32(result);
//            }
//        }
//    }
//}
