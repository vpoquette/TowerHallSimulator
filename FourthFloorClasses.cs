using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class FourthFloorClasses : IClassroomInformation
    {
        public String testMethod()
        {
            return "yo";
        }
        public void Main()
        {
            string[] analogies = { "classroom", "sports", "video game", "animal", "job", "technology", "religion", "nature", "weather" };
            string[] reactions = { "understand perfectly", "are more confused than ever", "are starting to understand", "are nodding along" };
            string[] specialActivities = { "quiz", "film", "in-class essay", "guest speaker", "group activity", "technology", "independent project work"};

            FourthFloorClasses class4414 = new FourthFloorClasses();
            class4414.ClassInSession("4414", reactions, analogies, specialActivities);
            // uncomment once we know one works
            /*
            Classroom class4605 = await ClassInSession("4605", reactions, analogies, specialActivities);
            Classroom class4611 = await ClassInSession("4611", reactions, analogies, specialActivities);
            Classroom class4105 = await ClassInSession("4105", reactions, analogies, specialActivities);
            Classroom class4115 = await ClassInSession("4115", reactions, analogies, specialActivities);
            Classroom class4119 = await ClassInSession("4119", reactions, analogies, specialActivities);
            Classroom class4125 = await ClassInSession("4125", reactions, analogies, specialActivities);
            Classroom class4141 = await ClassInSession("4141", reactions, analogies, specialActivities);
            */
        }
        public void ClassInSession(String classNum, String[] reactions, String[] analogies, String[] specialActivities)
        {
            Random activity = new Random();
            int randomActivity = activity.Next(1, 2);
            if (randomActivity == 1) {
                Lecture(reactions, analogies, classNum);
            }
            else if (randomActivity == 2) { 
                SpecialActivity(specialActivities);
            }
            ClassOver();
        }
        public async void Lecture(String[] reactions, String[] analogies, String classNum)
        {
            RandomAnalogy(analogies, classNum);
            await Task.Delay(3000); // students must consider the analogy before they react
            RandomReaction(reactions);
        }

        public String SpecialActivity(String[] specialActivities)
        {
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, specialActivities.Length);
            String whatYouSee = ("You look through the door and see the students engaged in a " + specialActivities[randomActivity] + ".");
            RandomAttendance();
            return whatYouSee;
        }

        public String RandomAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(1, 101); // generates number from 1 to 100
            String classAttendance = (attendance + "% of students are in attendance today.");
            return classAttendance;
        }

        public String RandomAnalogy(String[] analogies, String classNum)
        {
            Random randomAnalogies = new Random();
            int randomAnalogy = randomAnalogies.Next(0, analogies.Length);
            String profAnalogy = ("In classroom #" + classNum + ", the Professor uses a " + analogies[randomAnalogy] + " analogy to explain the concept.");
            return profAnalogy;
        }

        public String RandomReaction(String[] reactions)
        {
            Random randomReaction = new Random();
            int randomReact = randomReaction.Next(0, reactions.Length);
            String studentReaction = ("The students " + reactions[randomReact]);
            return studentReaction;
        }

        public String ClassOver()
        {
            return "Class dismissed!";
        }
    }
}