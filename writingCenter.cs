using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class WritingCenter
    {
        public String Center()
        {
            string[] writingActivities = { "reading over an essay", "using the computers", "printing something off", "discussing their writing with a tutor", "signing in" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, writingActivities.Length);
            int otherRandomActivity = randomActivities.Next(0, writingActivities.Length);
            return ("As you step into the writing center, you see a few students " + writingActivities[randomActivity] + " and " + writingActivities[otherRandomActivity] + ".");
        }
    }
}