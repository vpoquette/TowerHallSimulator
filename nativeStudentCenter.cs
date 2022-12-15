using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class NativeStudentCenter
    {
        public String Center()
        {
            string[] randomList = { "smudging", "beading", "studying", "chatting", "reading", "listening to music" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, randomList.Length);
            return ("Inside the Jiiman Abiwin, you see a few students " + randomList[randomActivity] + ".");
        }
    }
}