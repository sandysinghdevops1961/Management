using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEntity
{
    #region [Global Message Result Entity]
    /// <summary>
    /// Get or set the Global Message ResultSet.
    /// </summary>
    public class ResultSet
    {
        #region [Variables]

        private DateTime _requestDateTime = DateTime.UtcNow;
        #endregion [Variables]
        #region [Property]
        /// <summary>
        /// Set the CurrentRequestDateTime.
        /// </summary>
        public DateTime RequestDateTime
        {
            get { return _requestDateTime; }
            set { _requestDateTime = value; }
        }

        /// <summary>
        /// Set the CurrentResponseDateTime.
        /// </summary>
        public DateTime ResponseDateTime { get; set; }

        /// <summary>
        /// Get or set the ResponseIsSuccess property.
        /// </summary>
        public bool? ResponseIsSuccess { get; set; }

        /// <summary>
        /// Get or set the ErrorMessage property.
        /// </summary>
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Get or set the ErrorCode property.
        /// </summary>
        public ErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Get or set the MethodName property.
        /// </summary>
        public string? MethodName { get; set; }
        #endregion [Property]
    }

    
    #endregion [Global Message Result Entity]
}
