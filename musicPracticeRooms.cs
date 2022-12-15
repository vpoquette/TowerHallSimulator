using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class MusicPracticeRooms
    {
        public String PracticeRooms()
        {
            string[] genres = { "jazz", "classical", "pop", "folk", "rock", "country" };
            string[] styles = { "confidently", "uncertainly", "creatively", "quietly", "loudly", "beautifully", "painfully" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, genres.Length);
            return ("As you walk past the closed doors to the practice rooms, you hear " + genres[randomActivity] + " music being played " + styles[randomActivity] + ".");
        }
    }
}