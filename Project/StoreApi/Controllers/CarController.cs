using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreApi.Controllers
{
    public class CarController : Controller
    {
        private readonly ICar _car;

        public CarController(ICar car)
        {
            _car = car;
        }
        [AllowAnonymous]
        [ProducesDefaultResponseType(typeof(List<Car>))]
        [HttpGet(ApiRoutes.Car.GetCars)]
        public async Task<IActionResult> GetCars()
        {
            var result = await _car.getCars();
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(Car))]
        [HttpGet(ApiRoutes.Car.GetCarId)]
        public async Task<IActionResult> GetCar([FromRoute] int id)
        {
            var result = await _car.getCar(id);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(Car))]
        [HttpPost(ApiRoutes.Car.AddCarId)]
        public async Task<IActionResult> AddCar([FromBody] Car car)
        {
            if (car.Vin.Length != 7 || car.Vin.Length != 17)
            {
                return BadRequest("Invalid Vin");
            }
            var result = await _car.addCar(car);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(Car))]
        [HttpPut(ApiRoutes.Car.EditCarId)]
        public async Task<IActionResult> EditCar([FromBody] Car car)
        {
            var result = await _car.editCar(car);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(Car))]
        [HttpDelete(ApiRoutes.Car.DeleteCarId)]
        public async Task<IActionResult> DeleteCar([FromRoute] int id)
        {
            var result = await _car.deleteCar(id);
            return Ok(result);
        }
    }
}
