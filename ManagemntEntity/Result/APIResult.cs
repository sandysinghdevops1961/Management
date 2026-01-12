namespace ManagementEntity
{
    public class APIResult
    {
        #region [Property]
        public  object? APIRequest { get; set; }
        public DataContextResult? DatabaseResultSet { get; set; }
        public BusinessContextResult? BusinessContextResultSet { get; set; }
        public object? APIResponse { get; set; }
        public ResultSet? MessageResult { get; set; }
        #endregion [Property]
    }
}
