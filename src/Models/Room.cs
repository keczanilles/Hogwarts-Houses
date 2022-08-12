using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Web;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Room
    {
        public int Id { get; set; }

        private HashSet<Student> _students;

        public int Capacity { get;}

        public bool IsAvailable => _students.Count < Capacity;

        public bool NeedRenovation { get; set; }

        public Room(int id)
        {
            Id = id;
            Capacity = 5;
            NeedRenovation = false;
            _students = new();
        }

        public HashSet<Student> GetAllStudents()
        {
            return _students;
        }

        public void AddStudent(Student student)
        {
            if (IsAvailable)
            {
                _students.Add(student);
            }
            
        }
    }
}
