using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    interface IActivity
    {
        public String SpecialActivity()
        {
            string[] specialActivities = { "taking a quiz", "watching a film", "writing an in-class essay", "listening to a guest speaker", "a group activity", "independent project work" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, specialActivities.Length);
            return ("You look through the door and see the students engaged in " + specialActivities[randomActivity] + ".");
        }
    }
}
