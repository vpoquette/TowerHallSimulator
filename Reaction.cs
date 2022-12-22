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
    public class Reaction : IReaction
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vpoquette\Documents\THSclassrooms.mdf;Integrated Security=True;Connect Timeout=30";
        ArrayList reactions = new ArrayList();
        public String RandomReaction()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string SQLtext = "SELECT reaction FROM reactions";
                using (SqlCommand command = new SqlCommand(SQLtext, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string reaction = reader["reaction"].ToString();
                        reactions.Add(reaction);
                    }
                }
                connection.Close(); 
                Random randomReaction = new Random();
                int randomReact = randomReaction.Next(0, reactions.Count);
                return ("The students " + reactions[randomReact] + ".");
            }
        }
    }
}