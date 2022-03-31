using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc5ParameterisedConstructor
{
    public class MoodAnalyser
    {
        /// <summary>
        /// The message
        /// </summary>
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Analysers the mood.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="MoodAnalyserCustomExeption">
        /// Mood Should Not be Empty
        /// or
        /// Mood Should Not be Null
        /// </exception>
        public string AnalyserMood()
        {
           
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomExeption(MoodAnalyserCustomExeption.ExceptionType.Empty_Message, "Mood Should Not be Empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomExeption(MoodAnalyserCustomExeption.ExceptionType.Null_Message, "Mood Should Not be Null");
            }
        }
    }
}


