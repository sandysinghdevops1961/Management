using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEntity
{
    public class DatabaseResult:ResultSet
    {
        #region [Property]
        /// <summary>
        /// Get or set the DatabaseRequest property.
        /// </summary>
        public object? DatabaseRequest { get; set; }

        /// <summary>
        /// Get or set the DatabaseResponse property.
        /// </summary>
        public object? DatabaseResponse { get; set; }

        #endregion [Property]
    }
}
