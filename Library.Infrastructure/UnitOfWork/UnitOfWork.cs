using Library.Domain.Repositories;
using Library.Domain.UnitOfWork;
using Library.Infrastructure.Repositories;

namespace Library.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryDbContext _dbContext;
        private IBookRepository _bookRepository;

        public UnitOfWork(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IBookRepository BookRepository
        {
            get { return _bookRepository = _bookRepository ?? new BookRepository(_dbContext); }
        }

        public void Commit()
            => _dbContext.SaveChanges();

        public async Task CommitAsync()
            => await _dbContext.SaveChangesAsync();

        public void Rollback()
            => _dbContext.Dispose();

        public async Task RollbackAsync()
            => await _dbContext.DisposeAsync();
    }
}
