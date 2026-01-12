using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEntity
{
    public class ResultSet
    {
        public DateTime RequestDateTime { get; set; }

        public DateTime ResponseDateTime { get; set; }

        public bool? ResponseIsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public string? ErrorCode { get; set; }

        public string? MethodName { get; set; }
    }
}
