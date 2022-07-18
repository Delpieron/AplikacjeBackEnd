using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Models;
using StoreApi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreApi.Controllers
{
    public class CarPartController : Controller
    {
        private readonly ICarPart _carPart;

        public CarPartController(ICarPart carPart)
        {
            _carPart = carPart;
        }
        [AllowAnonymous]
        [ProducesDefaultResponseType(typeof(List<CarPart>))]
        [HttpGet(ApiRoutes.CarParts.GetCarParts)]
        public async Task<IActionResult> GetCarPart()
        {
            var result = await _carPart.getCarParts();
            return Ok(result);
        }
        [AllowAnonymous]
        [ProducesDefaultResponseType(typeof(CarPart))]
        [HttpGet(ApiRoutes.CarParts.GetCarPartsId)]
        public async Task<IActionResult> GetCarPart([FromRoute] int id)
        {
            var result = await _carPart.getCarPart(id);
            return Ok(result);
        }

        [ProducesDefaultResponseType(typeof(CarPart))]
        [HttpPost(ApiRoutes.CarParts.AddCarPartsId)]
        public async Task<IActionResult> AddCarPart([FromBody] CarPart carPart)
        {
            var result = await _carPart.addCarPart(carPart);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(CarPart))]
        [HttpPut(ApiRoutes.CarParts.EditCarPartsId)]
        public async Task<IActionResult> EditCarPart([FromBody] CarPart carPart)
        {
            var result = await _carPart.editCarPart(carPart);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(CarPart))]
        [HttpDelete(ApiRoutes.CarParts.DeleteCarPartsId)]
        public async Task<IActionResult> DeleteCarPart([FromRoute] int id)
        {
            var result = await _carPart.deleteCarPart(id);
            return Ok(result);
        }
    }
}
