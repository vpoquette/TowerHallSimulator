using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class MusicLibrary
    {
        public String Library()
        {
            string[] libraryActivities = { "discussing music", "organizing music", "browsing the filing system", "watering the plants", "studying music", "discussing a class" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, libraryActivities.Length);
            return ("Inside the music library, you see a few students " + libraryActivities[randomActivity] + ".");
        }
    }
}