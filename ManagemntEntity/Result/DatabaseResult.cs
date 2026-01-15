using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ManagementEntity
{
    public class DatabaseResult:ResultSet
    {
        #region [Property]
        /// <summary>
        /// Get or set the DatabaseRequest property.
        /// </summary>
        [JsonIgnore]
        public object? DatabaseRequest { get; set; }

        /// <summary>
        /// Get or set the DatabaseResponse property.
        /// </summary>
        [JsonIgnore]

        public object? DatabaseResponse { get; set; }

        #endregion [Property]
    }
}
