using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP.Oefenproject.DAL.Model;
using AP.Oefenproject.BLL.Interfaces;

namespace AP.Oefenproject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CircuitsController : ControllerBase
    {
        private ICircuitService _circuitService;

        public CircuitsController(ICircuitService circuitService)
        {
            _circuitService = circuitService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _circuitService.GetAll();

            if(result.Any() == false)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _circuitService.GetById(id);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Circuit circuit)
        {
            var result = _circuitService.Add(circuit);

            if (result == null)
            {
                return BadRequest();
            }
            return Created("", result);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _circuitService.Delete(id);
            }
            catch (Exception)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] Circuit circuit)
        {
            try
            {
                _circuitService.Update(circuit);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
