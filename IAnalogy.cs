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
            string[] analogies = { "a classroom", "a sports", "a video game", "an animal", "a job", "a technology", "a religion", "a nature", "a weather" };
            Random randomAnalogies = new Random();
            int randomAnalogy = randomAnalogies.Next(0, analogies.Length);
            return ("During the lecture, the professor uses " + analogies[randomAnalogy] + " analogy.");
        }
    }
}
