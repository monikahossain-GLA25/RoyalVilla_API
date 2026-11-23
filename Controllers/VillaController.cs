using Microsoft.AspNetCore.Mvc;

namespace RoyalVilla_API.Controllers
{
    [ApiController]
    [Route("api/villa")]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public string GetVillas()
        {
            return "Get All Villas";
        }
        [HttpGet("{id}")]
        public string GetVilla(int id)
        {
            return $"Get Villa with Id: {id}";
        }
    }
}