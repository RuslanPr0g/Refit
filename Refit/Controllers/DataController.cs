using Microsoft.AspNetCore.Mvc;
using RefitProject.RefitApiFactories;


namespace RefitProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IUniversityRestServiceFactory _refitApiFactory;

        public DataController(IUniversityRestServiceFactory refitApiFactory)
        {
            _refitApiFactory = refitApiFactory;
        }

        [HttpGet("/universities/{country}")]
        public IActionResult GetUniversitiesByCountryName(string country)
        {
            var data = _refitApiFactory.GetRestService().GetUniversities(country);

            if (data is null)
            {
                return BadRequest("Something went wrong or country doesn't exist.");
            }
            else
            {
                return Ok(data);
            }
        }
    }
}
