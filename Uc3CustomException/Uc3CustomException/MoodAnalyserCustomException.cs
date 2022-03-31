using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc3CustomException
{
    public class MoodAnalyserCustomExeption : Exception
    {
        /// <summary>
        /// Exception Type
        /// </summary>
        public enum ExceptionType
        {
            Null_Message, Empty_Message,
            No_Such_Field, No_Such_Method,
            No_Such_Class, Object_Creation_Issue
        }

        /// <summary>
        /// The type
        /// </summary>
        private readonly ExceptionType type;
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyserCustomExeption"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public MoodAnalyserCustomExeption(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
 