using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuisnessLogicLayer.DTO;
using BuisnessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectMainV2._1.Controllers
{
    [Route("api/[controller]")]
    public class SpendingController : Controller
    {
        ISpendingService _SpendingService;
        public SpendingController(ISpendingService SpendingService)
        {
            _SpendingService = SpendingService;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpendingDTO>>> Get()
        {
            try
            {
                return Ok(await _SpendingService.GetAllSpending());
            }
            catch
            {
                return NotFound();
            }

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SpendingDTO>> Get(int id)
        {
            try
            {
                return Ok(await _SpendingService.GetSpendingById(id));
            }
            catch
            {
                return NotFound();
            }
        }
        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]SpendingDTO spendingDTO)
        {
            try
            {
                await _SpendingService.AddSpending(spendingDTO);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        // PUT api/<controller>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody]SpendingDTO spendingDTO)
        {
            try
            {
                await _SpendingService.UpdateSpending(spendingDTO);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _SpendingService.DeleteSpending(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}