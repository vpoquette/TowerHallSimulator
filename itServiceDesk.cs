using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class ITServiceDesk
    {
        public String Desk()
        {
            string[] deskActivities = { "pointing at something on a laptop", "explaining a technical issue", "explaining a technical solution", "returning a laptop cart", "talking on the phone", "showing somebody their phone" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, deskActivities.Length);
            int otherRandomActivity = randomActivities.Next(0, deskActivities.Length);
            return ("As you pass by the IT Service Desk, you see a few students " + deskActivities[randomActivity] + " and " + deskActivities[otherRandomActivity] + ".");
        }
    }
}