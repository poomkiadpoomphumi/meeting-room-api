using Microsoft.AspNetCore.Mvc;
using dotnet_api.Services;
using dotnet_api.Models;
using MongoDB.Driver;

namespace dotnet_api.Controllers
{
    [ApiController]
    [Route("api/bookings")]
    public class BookingsController : ControllerBase
    {
        private readonly MongoDbService _mongoDbService;
        public BookingsController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }
        [HttpGet]
        public IActionResult GetBookings()
        {
            try
            {
                var collection = _mongoDbService.GetCollection<Booking>("bookings");
                var bookings = collection.Find(FilterDefinition<Booking>.Empty)
                                         .SortByDescending(b => b.MeetingInsertTimestamp)  // Ensure Booking has CreatedAt
                                         .Limit(10)
                                         .ToList();
                return Ok(bookings);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
