using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc5ParameterisedConstructor
{
    public class MoodAnalyserFactory
    {
        /// <summary>
        /// Creates the mood analyser using parameterized constructor.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructorName">Name of the constructor.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        /// <exception cref="Uc5ParameterisedConstructor.MoodAnalyserCustomExeption">
        /// Constructor is Not Found
        /// or
        /// Class Not Found
        /// </exception>
        public static object CreateMoodAnalyserUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    System.Reflection.ConstructorInfo con = type.GetConstructor(new[] { typeof(string) });
                    object instance = con.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserCustomExeption(MoodAnalyserCustomExeption.ExceptionType.No_Such_Method, "Constructor is Not Found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomExeption(MoodAnalyserCustomExeption.ExceptionType.No_Such_Class, "Class Not Found");
            }
        }
    }
}
