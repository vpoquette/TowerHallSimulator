using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    interface IAttendance
    {
        public String RandomAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(1, 101); // generates number from 1 to 100
            return (attendance + "% of the students are in attendance today.");
        }
    }
}
