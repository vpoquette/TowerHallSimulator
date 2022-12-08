using System;
using System.Collections.Generic;

namespace TowerHallSimulator.Models
{
    public class ClassRepository
    {
        List<ClassModel> towerClasses = new List<ClassModel>();
        public ClassRepository()
        {
            towerClasses.Add(new ClassModel(0, "Placeholder", "Professor", 20, 100, "8:00"));
            towerClasses.Add(new ClassModel(1, "Placeholder", "Professor", 20, 100, "8:00"));
            towerClasses.Add(new ClassModel(2, "Placeholder", "Professor", 20, 100, "8:00"));
        }

        public List<ClassModel> getAllClasses()
        {
            return (towerClasses);
        }

        public ClassModel getOneClass(int index)
        {
            return (towerClasses[index]);
        }
    }
}
