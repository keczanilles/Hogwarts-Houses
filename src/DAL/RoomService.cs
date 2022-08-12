using System.Collections.Generic;
using HogwartsHouses.Models;

namespace HogwartsHouses.DAL
{
    public class RoomService : IRoomService
    {
        private IRepository<Room> _repository { get; }

        public RoomService(IRepository<Room> repository)
        {
            _repository = repository;
        }

        public void AddRoom(Room room)
        {
            _repository.AddRoom(room);
        }

        public void AddStudentToRoom(int roomId, string name)
        {
            _repository.AddStudentToRoom(roomId, name);
        }

        public void AddStudent(Student student)
        {
            _repository.AddStudent(student);
        }

        public HashSet<Room> GetRooms()
        {
            return _repository.GetRooms();
        }

        public HashSet<Student> GetStudents()
        {
            return _repository.GetStudents();
        }

        public Room GetRoom(int id)
        {
            return _repository.GetRoom(id);
        }

        public void DeleteRoom(int id)
        {
            _repository.DeleteRoom(id);
        }

        public void UpdateRoom(int id)
        {
            _repository.UpdateRoom(id);
        }

        public HashSet<Room> GetAvailableRooms()
        {
            return _repository.GetAvailableRooms();
        }

        public HashSet<Room> GetStudentsWithOnlyRats()
        {
            return _repository.GetStudentsWithOnlyRats();
        }
    }
}
