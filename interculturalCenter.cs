using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class InterculturalCenter
    {
        public String Center()
        {
            string[] icActivities = { "playing music", "studying", "eating", "chatting", "making a craft", "making a poster" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, icActivities.Length);
            int otherRandomActivity = randomActivities.Next(0, icActivities.Length);
            return ("As you pass by the Intercultural Center, you see some students " + icActivities[randomActivity] + " and " + icActivities[otherRandomActivity] + ".");
        }
    }
}