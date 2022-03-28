using Library.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkRepositoryPatterns.Dtos;
using UnitOfWorkRepositoryPatterns.Services;

namespace UnitOfWorkRepositoryPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        public IBookService _bookService { get; set; }
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet(Name = "Books")]
        public async Task<IEnumerable<Book>> GetAll()
          => await _bookService.GetAll();

        [HttpPost]
        public async Task AddBook([FromBody] BookDto book)
        {
            await _bookService.AddBook(book);
        }
    }
}
