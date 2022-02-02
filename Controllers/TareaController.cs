using appTareas.interfaces;
using appTareas.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace appTareas.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TareaController : ControllerBase
    {
        private readonly ITareaServices _tareaServices;
        public TareaController(ITareaServices tareaServices)
        {
            _tareaServices = tareaServices;
        }

        [HttpGet]
        [Route("GettAll")]
        public  dynamic Get()
        {
            try
            {
                return StatusCode(200, _tareaServices.getAll());
            }
            catch (Exception err)
            {
                return StatusCode(500, err.Message);
            }
        }

        [HttpPost]
        [Route("Save")]
        public IActionResult Save(Tarea tarea)
        {
            try
            {
                 _tareaServices.Create(tarea);
                return StatusCode(201);
            }
            catch (Exception err)
            {
                return StatusCode(500, err.Message);
            }
        }
    }
}
