using System;

namespace TowerHallSimulator.Models
{
    public class StudentModel
    {
        int id;
        string name;
        int credits;

        public StudentModel(int id, string name, int credits)
        {
            this.id = id;
            this.name = name;
            this.credits = credits;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Credits { get => credits; set => credits = value; }
    }
}