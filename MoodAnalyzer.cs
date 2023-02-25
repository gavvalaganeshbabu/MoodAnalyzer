using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    internal class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer() { 
        
        }
        public MoodAnalyzer(string message) {
            this.message = message;
        }
        public string moodAnalyzer(string s) {
            if (message.ToLower().Contains("sad")){
                return "SAD";
            }
            else {
                return "HAPPY";
            }
            
        }
    }
}
