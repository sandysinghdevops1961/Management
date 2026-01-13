using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEntity
{
    #region [BusinessResult Entity]
    /// <summary>
    /// Get or set the BusinessResult
    /// </summary>
    public class BusinessResult : ResultSet
    {
        #region [Property]
        /// <summary>
        /// Get or set the BusinessRequest property.
        /// </summary>
        public object? BusinessRequest { get; set; }

        /// <summary>
        /// Get or set the BusinessResponse property.
        /// </summary>
        public object? BusinessResponse { get; set; }

        #endregion [Property]
    }
    #endregion [BusinessResult Entity]
}
