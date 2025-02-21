using Microsoft.AspNetCore.Mvc;
using dotnet_api.Services;
using dotnet_api.Models;
using MongoDB.Driver;

namespace dotnet_api.Controllers
{
    [ApiController]
    [Route("api/rooms")]
    public class RoomController : ControllerBase
    {
        private readonly MongoDbService _mongoDbService;
        public RoomController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }
        [HttpGet]
        public IActionResult GetRooms()
        {
            try
            {
                var collection = _mongoDbService.GetCollection<Room>("rooms");
                var users = collection.Find(FilterDefinition<Room>.Empty).ToList();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
