using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class Counseling
    {
        public String Counsel()
        {
            string[] counselingActivities = { "sitting down for therapy", "quietly discussing something", "looking over paperwork", "creating a poster", "scheduling an appointment"};
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, counselingActivities.Length);
            return ("As you approach the counseling office, you see a few people " + counselingActivities[randomActivity] + ".");
        }
    }
}