using Microsoft.AspNetCore.Mvc;
using dotnet_api.Services;
using dotnet_api.Models;
using MongoDB.Driver;

namespace dotnet_api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly MongoDbService _mongoDbService;
        public UsersController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            try
            {
                var collection = _mongoDbService.GetCollection<User>("users");
                var users = collection.Find(FilterDefinition<User>.Empty).ToList();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
