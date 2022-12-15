using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class StormsDen
    {
        public String Den()
        {
            string[] stormsActivities = { "studying", "eating", "watching TV", "playing pool", "gathering for a club", "playing games" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, stormsActivities.Length);
            int otherRandomActivity = randomActivities.Next(0, stormsActivities.Length);
            return ("As you pass through Storm's Den, you see some students " + stormsActivities[randomActivity] + " and " + stormsActivities[otherRandomActivity] + ".");
        }
    }
}