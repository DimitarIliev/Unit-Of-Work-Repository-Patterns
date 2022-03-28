using Library.Domain.Entities;
using Library.Domain.Repositories;

namespace Library.Infrastructure.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(LibraryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
