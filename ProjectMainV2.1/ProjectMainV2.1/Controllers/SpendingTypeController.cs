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
    public class SpendingTypeController : Controller
    {
        ISpendingTypeService _SpendingTypeService;
        public SpendingTypeController(ISpendingTypeService SpendingTypeService)
        {
            _SpendingTypeService = SpendingTypeService;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpendingTypeDTO>>> Get()
        {
            try
            {
                return Ok(await _SpendingTypeService.GetAllSpendingType());
            }
            catch
            {
                return NotFound();
            }

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SpendingTypeDTO>> Get(int id)
        {
            try
            {
                return Ok(await _SpendingTypeService.GetSpendingTypeById(id));
            }
            catch
            {
                return NotFound();
            }
        }
        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]SpendingTypeDTO spendingTypeDTO)
        {
            try
            {
                await _SpendingTypeService.AddSpendingType(spendingTypeDTO);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        // PUT api/<controller>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody]SpendingTypeDTO spendingTypeDTO)
        {
            try
            {
                await _SpendingTypeService.UpdateSpendingType(spendingTypeDTO);
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
                await _SpendingTypeService.DeleteSpendingType(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}