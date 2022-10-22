using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyzerCustomException:Exception
    {
        
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
        }

        public ExceptionType Type;
        public MoodAnalyzerCustomException(ExceptionType Type, String message) : base(message)
        {
            this.Type = Type;
        }
    }
}
