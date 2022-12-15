using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    interface IReaction
    {
        public String RandomReaction()
        {
            string[] reactions = { "understand perfectly", "are more confused than ever", "are starting to understand", "are nodding along" };
            Random randomReaction = new Random();
            int randomReact = randomReaction.Next(0, reactions.Length);
            return ("The students " + reactions[randomReact] + ".");
        }
    }
}
