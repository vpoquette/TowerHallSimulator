using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class Analogy : IAnalogy
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vpoquette\Documents\THSclassrooms.mdf;Integrated Security=True;Connect Timeout=30";
        ArrayList analogies = new ArrayList();
        public String RandomAnalogy()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string SQLtext = "SELECT analogy FROM analogies";
                using (SqlCommand command = new SqlCommand(SQLtext, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string analogy = reader["analogy"].ToString();
                        analogies.Add(analogy);
                    }
                }
                connection.Close();
                Random randomAnalogies = new Random();
                int randomAnalogy = randomAnalogies.Next(0, analogies.Count);
                return ("During the lecture, the professor uses " + analogies[randomAnalogy] + " analogy.");
            }
        }
    }
}