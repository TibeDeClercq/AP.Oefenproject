using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AP.Oefenproject.WebApp.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Formatting;

namespace AP.Oefenproject.WebApp.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class CircuitsController : Controller
    {
        private HttpClient httpClient = new HttpClient();
        private string url = "https://localhost:44303/api/Circuits";

        //Get all circuits
        public async Task<IActionResult> Index()
        {
            List<Circuit> CircuitsList = new List<Circuit>();
            using (var response = await httpClient.GetAsync(url))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                CircuitsList = JsonConvert.DeserializeObject<List<Circuit>>(apiResponse);
            }
            return View(CircuitsList);
        }

        //GET Create
        public IActionResult Create()
        {
            return View();
        }

        //POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Circuit circuit)
        {
            if (ModelState.IsValid)
            {
                var response = await httpClient.PostAsync(url, circuit, new JsonMediaTypeFormatter());
                if(response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(circuit);
        }

        //GET Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Circuit circuit = new Circuit();
            using (var response = await httpClient.GetAsync(url + $"/{id}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                circuit = JsonConvert.DeserializeObject<Circuit>(apiResponse);
            }
            if(circuit == null)
            {
                return NotFound();
            }
            return View(circuit);
        }

        //POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? Circuit_id)
        {
            var response = await httpClient.DeleteAsync(url + $"/{Circuit_id}");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        //GET Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Circuit circuit = new Circuit();
            using (var response = await httpClient.GetAsync(url + $"/{id}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                circuit = JsonConvert.DeserializeObject<Circuit>(apiResponse);
            }
            if (circuit == null)
            {
                return NotFound();
            }
            return View(circuit);
        }

        //POST Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePost(Circuit circuit)
        {
            var response = await httpClient.PutAsync(url, circuit, new JsonMediaTypeFormatter());
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        ////GET Delete
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var obj = _context.Circuits.Find(id);
        //    if(obj == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(obj);
        //}

        //POST Delete
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeletePost(int? Circuit_id)
        //{
        //    var obj = _context.Circuits.Find(Circuit_id);
        //    if(obj == null)
        //    {
        //        return NotFound();
        //    }
        //    _context.Circuits.Remove(obj);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //Get Delete
        //public IActionResult Delete(int? id)
        //{
        //    if(id == null || id == 0)
        //    {
        //        return NotFound();
        //    }

        //    var circuit = _context.Circuits.Find(id);
        //    if(circuit == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(circuit);
        //}

        //POST Delete
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeletePost(int? id)
        //{
        //    var circuit = _context.Circuits.Find(id);

        //    if(circuit == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Circuits.Remove(circuit);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //[HttpPost] //Create
        //public IActionResult AddCircuit([FromBody] Circuit circuit)
        //{
        //    _context.Circuits.Add(circuit);
        //    _context.SaveChanges();

        //    return Created("", circuit);
        //}

        //#region Read
        //[HttpGet] //Read
        //public IActionResult GetCircuits()
        //{
        //    var circuits = _context.Circuits;
        //    if (circuits.Any() == false)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(circuits);
        //}

        //[HttpGet] //Read
        //[Route("/api/CircuitPage")]
        //public IActionResult GetCircuitPage([FromQuery]int pageNumber, [FromQuery]int amount)
        //{
        //    var circuits = _context.Circuits.Skip((pageNumber - 1) * amount)
        //                                    .Take(amount);

        //    if (circuits.Count() == 0)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(circuits);
        //}
        //#endregion

        //[HttpPut] //Update
        //public IActionResult ChangeCircuit([FromBody] Circuit circuit)
        //{
        //    try
        //    {
        //        _context.Circuits.Update(circuit);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception)
        //    {
        //        return NotFound();
        //    }
        //    return Ok();
        //}

        //#region Delete
        //[HttpDelete] //Delete
        //[Route("{id}")]
        //public IActionResult DeleteCircuit(int id)
        //{
        //    Circuit circuit = new() { Circuit_id = id };
        //    _context.Remove(circuit);
        //    _context.SaveChanges();

        //    return Ok();
        //}

        //[HttpDelete] //Delete
        //[Route("/api/CircuitsClear")]
        //public IActionResult ClearCircuits()
        //{
        //    var circuits = _context.Circuits.Where(circuit => circuit.Circuit_id != 1);
        //    foreach(Circuit circuit in circuits)
        //    {
        //        _context.Remove(circuit);
        //    }
        //    _context.SaveChanges();

        //    return Ok();
        //}
        //#endregion
    }
}
