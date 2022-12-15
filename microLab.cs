using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class MicroLab
    {
        public String Lab()
        {
            string[] labActivities = { "printing something off", "waiting for a computer to open up", "typing frantically", "typing steadily", "pacing back and forth", "on a Zoom call" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, labActivities.Length);
            int otherRandomActivity = randomActivities.Next(0, labActivities.Length);
            return ("As you pass by the micro lab, you see a few students " + labActivities[randomActivity] + " and " + labActivities[otherRandomActivity] + ".");
        }
    }
}