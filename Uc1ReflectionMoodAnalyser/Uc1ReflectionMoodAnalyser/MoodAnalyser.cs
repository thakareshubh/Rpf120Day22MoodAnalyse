using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc1ReflectionMoodAnalyser
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
        public string AnalyserMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }

    }
}
