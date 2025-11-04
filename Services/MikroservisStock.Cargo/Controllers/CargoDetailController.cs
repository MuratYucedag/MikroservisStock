using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MikroservisStock.Cargo.Context;
using MikroservisStock.Cargo.Entites;

namespace MikroservisStock.Cargo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailController : ControllerBase
    {
        private readonly CargoContext _context;
        public CargoDetailController(CargoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult CargoDetailList()
        {
            var values = _context.CargoDetails.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCargoDetail(CargoDetail cargoDetail)
        {
            _context.CargoDetails.Add(cargoDetail);
            _context.SaveChanges();
            return Ok("İşlem başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteCargoDetail(int id)
        {
            var value = _context.CargoDetails.Find(id);
            _context.CargoDetails.Remove(value);
            _context.SaveChanges();
            return Ok("İşlem başarılı");
        }

        [HttpPut]
        public IActionResult UpdateCargoDetail(CargoDetail cargoDetail)
        {
            _context.CargoDetails.Update(cargoDetail);
            _context.SaveChanges();
            return Ok("İşlem başarılı");
        }
    }
}
