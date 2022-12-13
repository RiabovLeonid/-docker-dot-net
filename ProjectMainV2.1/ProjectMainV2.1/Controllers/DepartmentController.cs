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
    public class DepartmentController : Controller
    {
        IDepartmentService _DepartmentService;
        public DepartmentController(IDepartmentService DepartmentService)
        {
            _DepartmentService = DepartmentService;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentDTO>>> Get()
        {
            try
            {
                return Ok(await _DepartmentService.GetAllDepartment());
            }
            catch
            {
                return NotFound();
            }

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentDTO>> Get(int id)
        {
            try
            {
                return Ok(await _DepartmentService.GetDepartmentById(id));
            }
            catch
            {
                return NotFound();
            }
        }
        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]DepartmentDTO departmentDTO)
        {
            try
            {
                await _DepartmentService.AddDepartment(departmentDTO);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        // PUT api/<controller>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody]DepartmentDTO departmentDTO)
        {
            try
            {
                await _DepartmentService.UpdateDepartment(departmentDTO);
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
                await _DepartmentService.DeleteDepartment(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}