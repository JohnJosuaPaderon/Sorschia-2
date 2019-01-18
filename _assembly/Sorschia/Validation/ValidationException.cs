using System;
using System.Runtime.Serialization;

namespace Sorschia.Validation
{
    [Serializable]
    public class ValidationException : Exception
    {
        public ValidationException(ValidationType validationType)
        {
            ValidationType = validationType;
        }

        public ValidationException(string message, ValidationType validationType) : base(message)
        {
            ValidationType = validationType;
        }

        public ValidationException(string message, ValidationType validationType, Exception innerException) : base(message, innerException)
        {
            ValidationType = validationType;
        }

        protected ValidationException(ValidationType validationType, SerializationInfo info, StreamingContext context) : base(info, context)
        {
            ValidationType = validationType;
        }

        public ValidationType ValidationType { get; }
    }
}
