using System;
using System.Collections.Generic;
using System.Linq;
using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;

namespace HogwartsHouses.DAL
{
    public class RoomSampler
    {
        public HashSet<Room> Rooms { get; private set; }

        public HashSet<Student> Students { get; private set; }

        public RoomSampler()
        {
            Rooms = new ();
            Students = new ();
            Initialize();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public void AddStudentToRoom(int roomId, string name)
        {
            GetRoom(roomId).AddStudent(Students.FirstOrDefault(student => student.Name == name));
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public HashSet<Room> GetRooms()
        {
            return Rooms;
        }

        public HashSet<Student> GetStudents()
        {
            return Students;
        }

        public Room GetRoom(int id)
        {
            return Rooms.FirstOrDefault(room => room.Id == id);
        }

        public void DeleteRoom(int id)
        {
            Rooms.Remove(GetRoom(id));
        }

        public void UpdateRoom(int id)
        {
            Room room = GetRoom(id);
            room.NeedRenovation = true;
        }

        public HashSet<Room> GetAvailableRooms()
        {
            return Rooms.Where(room => room.IsAvailable).ToHashSet();
        }

        public HashSet<Room> GetStudentsWithOnlyRats()
        {
            HashSet<Room>  rooms = new();

            foreach (Room room in Rooms)
            {
                bool isGood = true;

                foreach (Student student in room.GetAllStudents())
                {
                    if (student.PetType == PetType.Cat || student.PetType == PetType.Owl)
                    {
                        isGood = false;
                    }
                }

                if (isGood)
                {
                    rooms.Add(room);
                }
                
            }
            return rooms;
        }
    }
}
