using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string Analyse()
        {
            try
            {
                if (message == null)
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood can not be Empty");
                }

                    if (message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (MoodAnalyzerCustomException e)
            {
                
                return e.Message;

            }
        }
    }
}
