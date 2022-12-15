using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class Facilities
    {
        public String FacilitiesArea()
        {
            string[] facilitiesActivities = { "rushing to respond to an emergency", "lending a key to somebody", "talking on a walkie-talkie", "printing something off", "carrying a package", "pushing a cart full of supplies" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, facilitiesActivities.Length);
            return ("As you approach the facilities offices, you see staff members " + facilitiesActivities[randomActivity] + ".");
        }
    }
}