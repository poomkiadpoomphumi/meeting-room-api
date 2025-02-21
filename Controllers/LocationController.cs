using Microsoft.AspNetCore.Mvc;
using dotnet_api.Services;
using dotnet_api.Models;
using MongoDB.Driver;

namespace dotnet_api.Controllers
{
    [ApiController]
    [Route("api/locations")]
    public class LocationController : ControllerBase
    {
        private readonly MongoDbService _mongoDbService;
        public LocationController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }
        [HttpGet]
        public IActionResult GetLocation()
        {
            try
            {
                var collection = _mongoDbService.GetCollection<Location>("locations");
                var users = collection.Find(FilterDefinition<Location>.Empty).ToList();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
