using Domain.Models;
using Domain.UnitOfWork;

namespace UnitOfWorkRepositoryPatterns.Services
{
    public class BookService : IBookService
    {
        public IUnitOfWork _unitOfWork;
        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddBook(Book book)
        {
            _unitOfWork.BookRepository.Add(book);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Book>> GetAll()
            => await _unitOfWork.BookRepository.GetAllAsync();
    }
}
