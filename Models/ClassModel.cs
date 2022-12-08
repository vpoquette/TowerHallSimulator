using System;

namespace TowerHallSimulator.Models
{
    public class ClassModel
    {
        int id;
        string name;
        string professor;
        int studentNum;
        int roomNum;
        string classTime;

        public ClassModel(int id, string name, string professor, int studentNum, int roomNum, string classTime)
        {
            this.id = id;
            this.name = name;
            this.professor = professor;
            this.studentNum = studentNum;
            this.roomNum = roomNum;
            this.classTime = classTime;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Professor { get => professor; set => professor = value; }
        public int StudentNum { get => studentNum; set => studentNum = value; }
        public int RoomNum { get => roomNum; set => roomNum = value; }
        public string ClassTime { get => classTime; set => classTime = value; }
    }
}