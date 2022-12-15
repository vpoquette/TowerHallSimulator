using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    interface IAnalogy
    {
        public String RandomAnalogy()
        {
            string[] analogies = { "classroom", "sports", "video game", "animal", "job", "technology", "religion", "nature", "weather" };
            Random randomAnalogies = new Random();
            int randomAnalogy = randomAnalogies.Next(0, analogies.Length);
            return ("During the lecture, the professor uses a " + analogies[randomAnalogy] + " analogy to explain the concept.");
        }
    }
}
