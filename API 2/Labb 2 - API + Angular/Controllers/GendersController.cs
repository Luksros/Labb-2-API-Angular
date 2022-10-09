using Labb_2___API___Angular.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb_2___API___Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        public IGenderRepo _genders;
        public GendersController(IGenderRepo genders)
        {
            _genders = genders;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGenders()
        {
            var genders = _genders.GetAll();
            return Ok(genders);
        }

        [HttpGet("{id:int}")]
        public  async Task<IActionResult> GetGenderById(int id)
        {
            var gender = _genders.GetById(id);
            if (gender == null) return NotFound("Gender with this ID could not be found.");  
            return Ok(gender);
        } 
    }
}
