namespace ManagementEntity.Model
{
    #region [Visitor Entity]
    /// <summary>
    /// Visitor Entity
    /// </summary>
    public class Visitor
    {
        #region [Property]
        
        public string? VisitorName { get; set; }

        public string? VisitorMobileNo { get; set; }

        public string? VisitorComingFrom { get; set; }

        public string? WhomToSee { get; set; }

        public string? Purpose { get; set; }

        public TimeSpan? TimeIn { get; set; }

        public TimeSpan? TimeOut { get; set; }
        #endregion [Property]
    }
    #endregion [Visitor Entity]
}
