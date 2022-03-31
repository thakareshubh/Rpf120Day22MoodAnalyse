using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Uc4MoodAnalyserConstructur
{
    public class MoodAnalyserFactory
    {
        /// <summary>
        /// Creates the mood analyser.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructorName">Name of the constructor.</param>
        /// <returns></returns>
        /// <exception cref="Uc4MoodAnalyserConstructur.MoodAnalyserCustomExeption">
        /// Class Not Found
        /// or
        /// Constructor is Not Found
        /// </exception>
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyser = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyser);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserCustomExeption(MoodAnalyserCustomExeption.ExceptionType.No_Such_Class, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomExeption(MoodAnalyserCustomExeption.ExceptionType.No_Such_Method, "Constructor is Not Found");
            }
        }
    }
