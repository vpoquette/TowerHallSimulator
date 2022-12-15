using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class PhotographyDarkoom
    {
        public String Darkroom()
        {
            string[] darkroomActivities = { "soaking prints", "studying a photograph", "fiddling with a camera", "chatting with a professor", "taking a picture of something on the countertop" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, darkroomActivities.Length);
            return ("Inside the photography darkroom, you see a student " + darkroomActivities[randomActivity] + ".");
        }
    }
}