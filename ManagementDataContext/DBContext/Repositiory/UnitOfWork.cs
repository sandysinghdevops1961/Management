using ManagementDataContext;
using System.Data;

namespace ManagementDataContext
{
    public class UnitOfWork: IUnitOfWork
    {
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; }

        public UnitOfWork(IDbContext dbContext)
        {
            Connection = dbContext.CreateConnection();
            Connection.Open();
            Transaction = Connection.BeginTransaction();
        }

        public void Commit() => Transaction.Commit();
        public void Rollback() => Transaction.Rollback();

        public void Dispose()
        {
            Transaction?.Dispose();
            Connection?.Dispose();
        }
    }
}
