using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class Reaction : IReaction
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