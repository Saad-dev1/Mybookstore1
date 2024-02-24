using BLL.IRepositries;
using DAL.Data;
using Microsoft.AspNetCore.Mvc;

namespace Mybookstore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepo _context;
        public CategoryController( ICategoryRepo context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCategory()
        {
            return Ok(_context.GetAll());
            
        }
    }

}
