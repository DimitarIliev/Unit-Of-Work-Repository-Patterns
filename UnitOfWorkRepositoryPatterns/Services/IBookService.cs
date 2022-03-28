using Library.Domain.Entities;
using UnitOfWorkRepositoryPatterns.Dtos;

namespace UnitOfWorkRepositoryPatterns.Services
{
    public interface IBookService
    {
        public Task<IEnumerable<Book>> GetAll();
        public Task AddBook(BookDto book);
    }
}
