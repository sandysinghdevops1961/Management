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
        /// Get or Set the DatabaseResultSet property.
        /// </summary>
        public DatabaseResult? DatabaseResultSet { get; set; }

        /// <summary>
        /// Get or set the BusinessResultSet property.
        /// </summary>
        public BusinessResult? BusinessContextResultSet { get; set; }

        /// <summary>
        /// Get or set the APIResponse property.
        /// </summary>
        public object? APIResponse { get; set; }

        /// <summary>
        /// Get or set the GenericMessage property.
        /// </summary>
        public ResultSet? MessageResult { get; set; }
        #endregion [Property]
    }
    #endregion [API ResultSet]
}
