using System;

namespace ManagementEntity
{
    
    public class Message
    {
        public static string UnknownError = "An unknown error has occurred.";
        public static string DatabaseError = "A database error occurred. Please try again later.";
        public static string BusinessError = "A business rule violation occurred.";
        public static string? ModelValidationError = "Model Validation failed. Please check your input.";
    }

    public enum MessageCode
    {
        UnknownError = 1000,
        DatabaseError = 1001,
        BusinessError = 1002,
        ModelValidationError = 1003,
        APIError=1004,
        Success=1005,
        RuntimeDatabaseException=1006,
        RuntimeBusinessException=1007
    }
}
