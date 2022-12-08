using System;
using System.Collections.Generic;

namespace TowerHallSimulator.Models
{
    public class StudentRepository
    {
        List<StudentModel> myStudents = new List<StudentModel>();
        public StudentRepository()
        {
            myStudents.Add(new StudentModel(0, "Tom", 16));
            myStudents.Add(new StudentModel(1, "Jad", 17));
            myStudents.Add(new StudentModel(2, "Reece", 23));
        }


        public List<StudentModel> getAllStudents()
        {
            return (myStudents);
        }

        public StudentModel getOneStudent(int index)
        {
            return (myStudents[index]);
        }
    }
}
