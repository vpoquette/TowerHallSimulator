using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class ExperientialLearning
    {
        public String Center()
        {
            string[] centerActivities = { "trying on professional clothes", "going over a resume", "signing up for study abroad", "exploring career options", "exploring study abroad opportunities", "practicing for an interview" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, centerActivities.Length);
            int otherRandomActivity = randomActivities.Next(0, centerActivities.Length);
            return ("As you approach the Experiential Learning Center, you see a group of students " + centerActivities[randomActivity] + " and " + centerActivities[otherRandomActivity] + ".");
        }
    }
}