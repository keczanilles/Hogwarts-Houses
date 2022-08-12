using System.Collections.Generic;
using HogwartsHouses.Models;

namespace HogwartsHouses.DAL
{
    public class RoomSampledRepository : IRepository<Room>
    {
        private RoomSampler _roomSampler { get; }

        public RoomSampledRepository()
        {
            _roomSampler = new RoomSampler();
        }

        public void AddRoom(Room room)
        {
           _roomSampler.AddRoom(room);
        }

        public void AddStudentToRoom(int roomId, string name)
        {
            _roomSampler.AddStudentToRoom(roomId, name);
        }

        public void AddStudent(Student student)
        {
            _roomSampler.AddStudent(student);
        }

        public HashSet<Room> GetRooms()
        {
            return _roomSampler.GetRooms();
        }

        public HashSet<Student> GetStudents()
        {
            return _roomSampler.GetStudents();
        }

        public Room GetRoom(int id)
        {
            return _roomSampler.GetRoom(id);
        }

        public void DeleteRoom(int id)
        {
            _roomSampler.DeleteRoom(id);
        }

        public void UpdateRoom(int id)
        {
            _roomSampler.UpdateRoom(id);
        }

        public HashSet<Room> GetAvailableRooms()
        {
            return _roomSampler.GetAvailableRooms();
        }

        public HashSet<Room> GetStudentsWithOnlyRats()
        {
            return _roomSampler.GetStudentsWithOnlyRats();
        }
    }
}
