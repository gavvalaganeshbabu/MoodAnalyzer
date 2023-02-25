using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    internal class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer() { }
       
        public string moodAnalyzer(string message) {
            try {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.Empty_Message, "Mood should not be Empty");
                }
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else if (message.ToLower().Contains("happy"))
                {
                    return "HAPPY";
                }
                else {
                    return "Invalid Message";
                    
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }



        }
    }
}
