using Business.Abstract;
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
    public class ColorsController : ControllerBase
    {
        IColorService _colorservice;

        public ColorsController(IColorService colorservice)
        {
            _colorservice = colorservice;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _colorservice.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _colorservice.GetById(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            var result = _colorservice.Add(color);
            if (result.Success == true)
            {

                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Color color)
        {
            var result = _colorservice.Delete(color);
            if (result.Success == true)
            {

                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Color color)
        {
            var result = _colorservice.Update(color);
            if (result.Success == true)
            {

                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
