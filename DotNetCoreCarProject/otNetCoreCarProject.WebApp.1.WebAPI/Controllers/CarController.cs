using DotNetCoreCarProject.Common.Models;
using DotNetCoreCarProject.WebApp._2.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace otNetCoreCarProject.WebApp._1.WebAPI.Controllers
{

    [Produces("application/json")]
    [Route("api/SearchCar")]
    public class CarController : Controller
    {
        private readonly ICar icar;

        public CarController(ICar car)
        {
            icar = car;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Car>))]

        public async Task<IActionResult> Get(CarSearchingParameters carSearchParameters)
        {
            var Cars = await icar.SearchCarAsync(carSearchParameters);

            if (Cars == null || !Cars.Any())
            {
                return NotFound();
            }
            return Json(Cars);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(List<Car>))]
        public async Task<IActionResult> Post([FromBody] Car car)
        {
            if (await icar.SaveCarAsync(car))
            {
                return Ok();
            }
            else
            {
                return BadRequest("Unable to save Car Data...!");
            }
        }




        [HttpDelete("delete/{id}")]
        [ProducesResponseType(200, Type = typeof(List<Car>))]
        public async Task<IActionResult> Delete(int id)
        {
            if (await icar.DeleteCarAsync(id))
            {
                return Ok();
            }
            else
            {
                return BadRequest("Unable to Delete Data");
            }

        }

        [HttpPut("{id}")]
        [ProducesResponseType(200, Type = typeof(List<Car>))]
        public async Task<IActionResult> UpdateBook ([FromBody] Car car, [FromRoute] int id)
        {
            if (await icar.UpdateCarAsync(car, id))
            {
                return Ok();
            }
            else
            {
                return BadRequest("Wrong Input");
            }
        }
    }
}
