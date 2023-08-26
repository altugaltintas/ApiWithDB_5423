using Api.Bussiness.Abstract;
using Api.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]  //LocalHost/api/employee
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        public IActionResult Get()
        {
            return Ok(_service.GetAllEmployees());

        }

        [HttpPost]


        public IActionResult Post([FromBody] Employee employee)
        {
            var created = _service.CreateEmployee(employee);
            return Ok(created);
        }




        [HttpGet("{id}")]   //LocalHost/api/employee/id  // parametre adı neyse uri için burada da onu kullanmak gerekir


        [HttpGet]
        [Route("getWithid/{id}")] //LocalHost/api/employee/getWithid/id 

        [HttpGet]
        [Route("[action]/{id}")] //LocalHost/api/employee/GetEmpoyeeById/id   //action parametre adı

        public IActionResult GetEmpoyeeById(int id)   //htt p://localhost:10160/api/employee/3   id si 3 olanı döndürüyor 

        {

            var employee = _service.GetEmployee(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound();
        }

        [HttpPut]

        [HttpPut]
        [Route("PutEmployee")]  //LocalHost/api/employee/PutEmployee/id

        public IActionResult Put([FromBody] Employee employee)
        {
            if (_service.GetEmployee(employee.ID) !=null)
            {
                return Ok(_service.UpdateEmployee(employee));
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]


        public IActionResult Delete(int id)
        
        {
            if (_service.GetEmployee(id) != null)
            {
                _service.DeleteEmployee(id);
                return Ok();
            }
            else return NotFound();
        }

    }
}
