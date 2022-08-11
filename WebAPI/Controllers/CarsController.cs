
using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
            
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getcarsbybrandid")]
        public IActionResult GetCarsByBrandId(int id)
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int id)
        {
            var result = _carService.GetCarsByColorId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getcardetailsbybrandandcolor")]
        public IActionResult GetCarDetailsByBrandAndColor(int brandId, int colorId)
        {
            var result = _carService.GetCarDetailsByBrandIdAndColorId(brandId, colorId);

            if (result.Success)
            {

                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcardetail")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpGet("getfilteredcars")]
        public IActionResult GetFilteredCars(int brandId, int colorId, int minDailyPrice, int maxDailyPrice)
        {
            var result = _carService.GetFilteredCars(brandId, colorId, minDailyPrice, maxDailyPrice);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }



        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success == true)
            {

                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success == true)
            {

                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success == true)
            {

                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
