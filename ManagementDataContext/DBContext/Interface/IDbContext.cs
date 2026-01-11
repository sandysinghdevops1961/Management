using System.Data;

namespace ManagementDataContext
{
    public interface IDbContext
    {
        IDbConnection CreateConnection();

    }
}
