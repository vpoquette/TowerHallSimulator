using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class VeteransCenter
    {
        public String Center()
        {
            string[] veteransActivities = { "coloring", "studying", "chatting with a staff member", "making a craft", "sharing their experiences", "petting the therapy dog" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, veteransActivities.Length);
            int otherRandomActivity = randomActivities.Next(0, veteransActivities.Length);
            return ("As you pass by the Veterans Center, you see a few students " + veteransActivities[randomActivity] + " and " + veteransActivities[otherRandomActivity] + ".");
        }
    }
}