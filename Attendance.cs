using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class Attendance : IAttendance
    {
        public String RandomAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(1, 101); // generates number from 1 to 100
            return (attendance + "% of the students are in attendance today.");
        }
    }
}