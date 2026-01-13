using System;

namespace ManagementEntity
{
    
    public class ErrorMessage
    {
        public static string UnknownError = "An unknown error has occurred.";
        public static string DatabaseError = "A database error occurred. Please try again later.";
        public static string BusinessError = "A business rule violation occurred.";
        public static string ValidationError = "Validation failed. Please check your input.";
    }

    public enum ErrorCode
    {
        UnknownError = 1000,
        DatabaseError = 1001,
        BusinessError = 1002,
        ValidationError = 1003
    }
}
