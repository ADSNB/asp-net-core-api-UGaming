using System.Data;

namespace UGaming.Context.Interfaces
{
    public interface IUnitOfWork
    {
        IDapperContext Context { get; }
        IDbTransaction Transaction { get; }
        IDbTransaction BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Snapshot);
        void Commit();
        void Rollback();
    }
}
