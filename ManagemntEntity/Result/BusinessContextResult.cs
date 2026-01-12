using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEntity
{
    public class BusinessContextResult:ResultSet
    {
        #region [Property]
        public object? BusinessRequest { get; set; }

        public object? BusinessResponse { get; set; }

        #endregion [Property]
    }
}
