using System.Text.Json.Serialization;

namespace ManagementEntity
{
    #region [API ResultSet]
    /// <summary>
    /// Get the APIResults.
    /// </summary>
    public class APIResult
    {
        #region [Property]
        /// <summary>
        /// Get or set the APIRequest property,
        /// </summary>
        public object? APIRequest { get; set; }

        /// <summary>
        /// Get or set the APIResponse property.
        /// </summary>
        public ResultSet? APIResponse { get; set; }

        #endregion [Property]
    }
    #endregion [API ResultSet]
}
