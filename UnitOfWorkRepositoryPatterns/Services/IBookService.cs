using Library.Domain.Models;

namespace UnitOfWorkRepositoryPatterns.Services
{
    public interface IBookService
    {
        public Task<IEnumerable<Book>> GetAll();
        public Task AddBook(Book book);
    }
}
