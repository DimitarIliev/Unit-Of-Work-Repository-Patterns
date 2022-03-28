using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace UnitOfWorkRepositoryPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpGet(Name = "Books")]
        public List<Book> GetAll()
          => _categoryService.GetCategories();
    }
}
