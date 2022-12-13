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
    [ApiController]
    public class EmployeeController : Controller
    {
        IEmployeeService _EmployeeService;
        public EmployeeController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>> Get()
        {
            try
            {
                return Ok(await _EmployeeService.GetAllEmployee());
            }
            catch
            {
                return NotFound();
            }

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDTO>> Get(int id)
        {
            try 
            {
                return Ok(await _EmployeeService.GetEmployeeById(id));
            }
            catch 
            {
                return NotFound();
            }
        }
        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]EmployeeDTO employee)
        {
            try
            {
                await _EmployeeService.AddEmployee(employee);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        // PUT api/<controller>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody]EmployeeDTO employee)
        {
            try
            {
                await _EmployeeService.UpdateEmployee(employee);
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
                await _EmployeeService.DeleteEmployee(id);
                return Ok();
            }
            catch 
            {
                return NotFound();
            }
        }
    }
}