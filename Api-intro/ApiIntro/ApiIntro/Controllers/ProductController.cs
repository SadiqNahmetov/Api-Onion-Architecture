using Microsoft.AspNetCore.Mvc;

namespace ApiIntro.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult  GetById(int id)
        {
            string name = "Sadiq" + id;
           return Ok(name);

        }


        [HttpGet]
        public IActionResult GetAll(int id)
        {
            List<string> names= new List<string>() { "Sadiq", "Ramil","Orxan","Esqin"};
            return Ok(names);

        }

    }
    }
