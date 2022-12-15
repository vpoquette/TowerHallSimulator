using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class HonorsLounge
    {
        public String Lounge()
        {
            string[] loungeActivities = { "on the computers", "waiting for the printer to finish printing", "reading quietly", "discussing a class", "studying in the comfy chairs", "browsing the bookshelf" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, loungeActivities.Length);
            int secondRandomActivity = randomActivities.Next(0, loungeActivities.Length);
            return ("Inside the honors lounge, you see a few students " + loungeActivities[randomActivity] + " and " + loungeActivities[secondRandomActivity] + ".");
        }
    }
}