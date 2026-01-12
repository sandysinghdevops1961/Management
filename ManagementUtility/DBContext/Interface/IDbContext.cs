using System.Data;

namespace ManagementUtility
{
    public interface IDbContext
    {
        IDbConnection CreateConnection();

    }
}
