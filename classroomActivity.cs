using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    interface classroomInformation // interface segregation who
    {
        Task<Classroom> ClassInSession(String classNum, String[] reactions, String[] analogies, String[] specialActivities);
        Task<Classroom> Lecture(String[] reactions, String[] analogies, String classNum);
        Task<Classroom> SpecialActivity(String[] specialActivities);
        void RandomAttendance();
        void RandomAnalogy(String[] analogies, String classNum);
        void RandomReaction(String[] reactions);
    }
}
