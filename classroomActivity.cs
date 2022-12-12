using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    interface IClassroomInformation // interface segregation who
    {
        async static Task<Classroom> ClassInSession(String classNum, String[] reactions, String[] analogies, String[] specialActivities)
        {
            var lecture = new Classroom();
            Random activity = new Random();
            int randomActivity = activity.Next(1, 2);
            if (randomActivity == 1)
            {
                lecture = await Lecture(reactions, analogies, classNum);
            }
            else if (randomActivity == 2)
            {
                lecture = await SpecialActivity(specialActivities);
            }
            return lecture;
        }
        async static Task<Classroom> Lecture(String[] reactions, String[] analogies, String classNum)
        {
            RandomAnalogy(analogies, classNum);
            await Task.Delay(3000); // students must consider the analogy before they react
            RandomReaction(reactions);
            return new Classroom();
        }
        async static Task<Classroom> SpecialActivity(String[] specialActivities)
        {
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, specialActivities.Length);
            await Task.Delay(1000); // give user a second to walk to the door
            Console.Write("You look through the door and see the students engaged in a " + specialActivities[randomActivity] + ".");
            RandomAttendance();
            return new Classroom();
        }
        async static void RandomAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(1, 101); // generates number from 1 to 100
            await Task.Delay(1000); // give user a second to walk to the door
            Console.Write(attendance + "% of students are in attendance today.");
        }
        static void RandomAnalogy(String[] analogies, String classNum)
        {
            Random randomAnalogies = new Random();
            int randomAnalogy = randomAnalogies.Next(0, analogies.Length);
            Console.Write("In classroom #" + classNum + ", the Professor uses a " + analogies[randomAnalogy] + " analogy to explain the concept.");
        }
        static void RandomReaction(String[] reactions)
        {
            Random randomReaction = new Random();
            int randomReact = randomReaction.Next(0, reactions.Length);
            Console.Write("The students " + reactions[randomReact]);
        }
    }
}
