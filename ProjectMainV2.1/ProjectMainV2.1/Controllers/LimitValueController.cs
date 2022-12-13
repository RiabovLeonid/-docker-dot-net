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
    public class LimitValueController : Controller
    {
        ILimitValueService _LimitValueService;
        public LimitValueController(ILimitValueService limitValueService)
        {
            _LimitValueService = limitValueService;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LimitValueDTO>>> Get()
        {
            try
            {
                return Ok(await _LimitValueService.GetAllLimitValue());
            }
            catch
            {
                return NotFound();
            }

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LimitValueDTO>> Get(int id)
        {
            try
            {
                return Ok(await _LimitValueService.GetLimitValueById(id));
            }
            catch
            {
                return NotFound();
            }
        }
        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]LimitValueDTO limitValueDTO)
        {
            try
            {
                await _LimitValueService.AddLimitValue(limitValueDTO) ;
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        // PUT api/<controller>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody]LimitValueDTO limitValueDTO)
        {
            try
            {
                await _LimitValueService.UpdateLimitValue(limitValueDTO);
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
                await _LimitValueService.DeleteLimitValue(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}