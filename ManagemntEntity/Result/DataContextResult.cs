using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEntity
{
    public class DataContextResult:ResultSet
    {
        #region [Property]
        public object? DatabaseRequest { get; set; }

        public object? DatabaseResponse { get; set; }

        #endregion [Property]
    }
}
