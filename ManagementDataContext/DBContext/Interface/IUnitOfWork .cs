using System.Data;

namespace ManagementDataContext
{
    public interface IUnitOfWork:IDisposable
    {
        IDbConnection Connection { get; }
        IDbTransaction Transaction { get; }
        void Commit();
        void Rollback();
    }
}
