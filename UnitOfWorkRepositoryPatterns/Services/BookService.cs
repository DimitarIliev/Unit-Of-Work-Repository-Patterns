using Library.Domain.Entities;
using Library.Domain.UnitOfWork;
using UnitOfWorkRepositoryPatterns.Dtos;

namespace UnitOfWorkRepositoryPatterns.Services
{
    public class BookService : IBookService
    {
        public IUnitOfWork _unitOfWork;
        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddBook(BookDto bookDto)
        {
            var book = new Book
            {
                Genre = bookDto.Genre,
                NmPages = bookDto.NmPages,
                Title = bookDto.Title,
            };

            _unitOfWork.BookRepository.Add(book);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Book>> GetAll()
            => await _unitOfWork.BookRepository.GetAllAsync();
    }
}
