﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TowerHallSimulator
{
    public class Classroom { }
    public class FourthFloorClasses : classroomInformation
    {
        public async Task Main() // does need to be async Task
        {
            string[] analogies = { "classroom", "sports", "video game", "animal", "job", "technology", "religion", "nature", "weather" };
            string[] reactions = { "understand perfectly", "are more confused than ever", "are starting to understand", "are nodding along" };
            string[] specialActivities = { "quiz", "film", "in-class essay", "guest speaker", "group activity", "technology", "independent project work"};

            Classroom class4414 = await ClassInSession("4414", reactions, analogies, specialActivities);
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
        public async Task<Classroom> ClassInSession(String classNum, String[] reactions, String[] analogies, String[] specialActivities)
        {
            var lecture = new Classroom();
            Random activity = new Random();
            int randomActivity = activity.Next(1, 2);
            if (randomActivity == 1) {
                lecture = await Lecture(reactions, analogies, classNum);
            }
            else if (randomActivity == 2) { 
                lecture = await SpecialActivity(specialActivities);
            }
            ClassOver();
            return lecture;
        }
        public async Task<Classroom> Lecture(String[] reactions, String[] analogies, String classNum)
        {
            RandomAnalogy(analogies, classNum);
            await Task.Delay(3000); // students must consider the analogy before they react
            RandomReaction(reactions);
            return new Classroom();
        }

        public async Task<Classroom> SpecialActivity(String[] specialActivities)
        {
            Random randomActivities = new Random();
            int randomActivity = randomActivities.Next(0, specialActivities.Length);
            await Task.Delay(1000); // give user a second to walk to the door
            Console.Write("You look through the door and see the students engaged in a " + specialActivities[randomActivity] + ".");
            RandomAttendance();
            return new Classroom();
        }

        public async void RandomAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(1, 101); // generates number from 1 to 100
            await Task.Delay(1000); // give user a second to walk to the door
            Console.Write(attendance + "% of students are in attendance today.");
        }

        public void RandomAnalogy(String[] analogies, String classNum)
        {
            Random randomAnalogies = new Random();
            int randomAnalogy = randomAnalogies.Next(0, analogies.Length);
            Console.Write("In classroom #" + classNum + ", the Professor uses a " + analogies[randomAnalogy] + " analogy to explain the concept.");
        }

        public void RandomReaction(String[] reactions)
        {
            Random randomReaction = new Random();
            int randomReact = randomReaction.Next(0, reactions.Length);
            Console.Write("The students " + reactions[randomReact]);
        }

        public static void ClassOver()
        {
            Console.WriteLine("Class dismissed!");
        }
    }
}