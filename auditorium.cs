using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class Auditorium
    {
        public String Mitchell()
        {
            string[] mitchellActivities = { "warming up their instruments", "warming up their voices", "playing in String Orchestra", "playing in Concert Band", "playing in Jazz Band", "singing in unison", "singing in harmony", "singing acapella" };
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, mitchellActivities.Length);
            return ("As you approach Mitchell Auditorium, you hear a group of students " + mitchellActivities[randomActivity] + ".");
        }
    }
}