using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    interface IClassroomInformation // interface segregation who
    {
        void ClassInSession(String classNum, String[] reactions, String[] analogies, String[] specialActivities)
        {
            Random activity = new Random();
            int randomActivity = activity.Next(1, 2);
            if (randomActivity == 1)
            {
                Lecture(reactions, analogies, classNum);
            }
            else if (randomActivity == 2)
            {
                SpecialActivity(specialActivities);
            }
        }
        async void Lecture(String[] reactions, String[] analogies, String classNum)
        {
            RandomAnalogy(analogies, classNum);
            await Task.Delay(3000); // students must consider the analogy before they react
            RandomReaction(reactions);
        }
        string SpecialActivity(String[] specialActivities)
        {
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, specialActivities.Length);
            String whatYouSee = ("You look through the door and see the students engaged in a " + specialActivities[randomActivity] + ".");
            return whatYouSee;
        }
        string RandomAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(1, 101); // generates number from 1 to 100
            String classAttendance = (attendance + "% of students are in attendance today.");
            return classAttendance;
        }
        string RandomAnalogy(String[] analogies, String classNum)
        {
            Random randomAnalogies = new Random();
            int randomAnalogy = randomAnalogies.Next(0, analogies.Length);
            String profAnalogy = ("In classroom #" + classNum + ", the Professor uses a " + analogies[randomAnalogy] + " analogy to explain the concept.");
            return profAnalogy;
        }
        string RandomReaction(String[] reactions)
        {
            Random randomReaction = new Random();
            int randomReact = randomReaction.Next(0, reactions.Length);
            String studentReaction = ("The students " + reactions[randomReact]);
            return studentReaction;
        }
    }
}
