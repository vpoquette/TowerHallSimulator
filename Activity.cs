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
    public class Activity : IActivity
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vpoquette\Documents\THSclassrooms.mdf;Integrated Security=True;Connect Timeout=30";
        ArrayList specialActivities = new ArrayList();
        public String SpecialActivity()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string SQLtext = "SELECT activity FROM activities";
                using (SqlCommand command = new SqlCommand(SQLtext, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string activity = reader["activity"].ToString();
                        specialActivities.Add(activity);
                    }
                }
                connection.Close();
                Random randomActivities = new Random();
                int randomActivity = randomActivities.Next(0, specialActivities.Count);
                return ("You look through the door and see the students engaged in " + specialActivities[randomActivity] + ".");
            }
        }
    }
}