using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class MusicHall
    {
        public String Hall()
        {
            string[] hallActivities = { "taking turns playing drums", "warming up for rehearsal", "singing in unison", "singing in harmony", "singing acapella", "taking turns playing the xylophone" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, hallActivities.Length);
            return ("As you approach the music hall, you perceive a group of students " + hallActivities[randomActivity] + ".");
        }
    }
}