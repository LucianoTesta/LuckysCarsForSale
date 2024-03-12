using LuckysCarsForSale.Data;
using LuckysCarsForSale.Dtos;
using LuckysCarsForSale.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LuckysCarsForSale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarSales : Controller
    {
        private readonly ICarService _carService;

        public CarSales(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<ActionResult<CarDTO>> GetCarInfoWithBuyerAndStatus()
        {
            var cars = await _carService.GetAllCars();

            if (cars == null)
            {
                return NotFound();
            }

            return Ok(cars);
        }
    }
}
