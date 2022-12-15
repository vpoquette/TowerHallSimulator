using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class McNair
    {
        public String Center()
        {
            string[] mcNairActivities = { "studying", "discussing a class", "reading", "working on the computer", "chatting with a professor" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, mcNairActivities.Length);
            return ("As you pass by the McNair Scholar Center, you perceive a group of students " + mcNairActivities[randomActivity] + ".");
        }
    }
}