using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class Mailroom
    {
        public String Mail()
        {
            string[] mailActivities = { "retrieving letters from their mailbox", "picking up a package", "dropping off a package", "sending mail to someone else", "opening a package", "opening an envelope" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, mailActivities.Length);
            int otherRandomActivity = randomActivities.Next(0, mailActivities.Length);
            return ("As you pass by the Mailroom, you see a few students " + mailActivities[randomActivity] + " and " + mailActivities[otherRandomActivity] + ".");
        }
    }
}