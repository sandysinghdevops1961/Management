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
        /// <summary>
        /// Declare requestDateTime Variable.
        /// </summary>
        private DateTime _requestDateTime = DateTime.UtcNow;

        /// <summary>
        /// Declare responseIsSuccess Variable.
        /// </summary>
        private bool? _success = false;

        #endregion [Variables]
        #region [Property]
        
        /// <summary>
        /// Get or set the ResponseIsSuccess property.
        /// </summary>
        public bool? Success
        {
            get { return _success; }
            set { _success = value; }
        }

        /// <summary>
        /// Get or set the Message property.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Get or set the MessageCode property.
        /// </summary>
        public MessageCode MessageCode { get; set; }

        /// <summary>
        /// Get or set the MethodName property.
        /// </summary>
        public string? MethodName { get; set; }
        #endregion [Property]
    }


    #endregion [Global Message Result Entity]
}
