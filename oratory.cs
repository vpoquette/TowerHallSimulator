using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class Oratory
    {
        public String Room()
        {
            string[] oratoryActivities = { "praying", "singing", "burning incense", "reading from cards", "reading books", "studying the Bible", "chatting", "lighting candles" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, oratoryActivities.Length);
            int otherRandomActivity = randomActivities.Next(0, oratoryActivities.Length);
            return ("As you pass by the Oratory, you see some students " + oratoryActivities[randomActivity] + " and " + oratoryActivities[otherRandomActivity] + ".");
        }
    }
}