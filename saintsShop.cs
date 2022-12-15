using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class SaintsShop
    {
        public String Shop()
        {
            string[] shopActivities = { "examining clothes from a rack", "browsing office supplies", "browsing gifts", "buying something at the register", "trying on merch", "browsing through knicknacks" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, shopActivities.Length);
            int otherRandomActivity = randomActivities.Next(0, shopActivities.Length);
            return ("As you pass by the Saints Shop, you see some students " + shopActivities[randomActivity] + " and " + shopActivities[otherRandomActivity] + ".");
        }
    }
}