using Library.Domain.Repositories;

namespace Library.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        IBookRepository BookRepository { get; }
        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
