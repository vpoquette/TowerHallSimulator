using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class TutoringCenter
    {
        public String Center()
        {
            string[] tutoringActivities = { "studying", "going over an assignment", "learning exam tips", "going over an exam", "drawing on the whiteboard", "signing in" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, tutoringActivities.Length);
            int otherRandomActivity = randomActivities.Next(0, tutoringActivities.Length);
            return ("As you pass by the tutoring center, you see a few students " + tutoringActivities[randomActivity] + " and " + tutoringActivities[otherRandomActivity] + ".");
        }
    }
}