using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class Activity : IActivity
    {
        public String SpecialActivity()
        {
            string[] specialActivities = { "taking quiz", "watching a film", "writing an in-class essay", "listening to a guest speaker", "group activity", "independent project work" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, specialActivities.Length);
            return ("You look through the door and see the students engaged in " + specialActivities[randomActivity] + ".");
        }
    }
}