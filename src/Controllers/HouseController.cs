using System.Collections.Generic;
using HogwartsHouses.DAL;
using HogwartsHouses.Models;
using Microsoft.AspNetCore.Mvc;

namespace HogwartsHouses.Controllers
{
    [ApiController]
    public class HouseController : Controller
    {
        public RoomService RoomService { get; set; }

        public HouseController(IRepository<Room> repository)
        {
            RoomService = new RoomService(repository);
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            ViewData["rooms"] = RoomService.GetRooms();
            return View();
        }

        [HttpGet("/rooms")]
        public HashSet<Room> GetRooms()
        {
            return RoomService.GetRooms();
        }

        [HttpPost("/rooms")]
        public void AddRoom([FromBody] Room room)
        {
            RoomService.AddRoom(room);
        }

        [HttpGet("/rooms/{roomId}")]
        public Room GetRoom(int roomId)
        {
            return RoomService.GetRoom(roomId);
        }

        [HttpDelete("/rooms/{roomId}")]
        public void DeleteRoom(int roomId)
        {
            RoomService.DeleteRoom(roomId);
        }

        [HttpPut("/rooms/{roomId}")]
        public void UpdateRoom(int roomId)
        {
            RoomService.UpdateRoom(roomId);
        }

        [HttpPut("/students/{roomId}/{studentName}")]
        public void AssignStudentToRoom(int roomId, string studentName)
        {
            RoomService.AddStudentToRoom(roomId, studentName);
        }

        [HttpGet("/rooms/available")]
        public HashSet<Room> GetAvailableRooms()
        {
            return RoomService.GetAvailableRooms();
        }

        [HttpGet("/rooms/rat-owners")]
        public HashSet<Room> RatOwners()
        {
            return RoomService.GetStudentsWithOnlyRats();
        }
    }
}
