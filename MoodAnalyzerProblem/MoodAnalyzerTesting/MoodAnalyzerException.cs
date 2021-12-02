using System;
using System.Runtime.Serialization;

namespace MoodAnalyzerProblem
{
    [Serializable]
    internal class MoodAnalyzerException : Exception
    {
        private object eNTERED_EMPTY;
        private string v;

        public MoodAnalyzerException()
        {
        }

        public MoodAnalyzerException(string message) : base(message)
        {
        }

        public MoodAnalyzerException(object eNTERED_EMPTY, string v)
        {
            this.eNTERED_EMPTY = eNTERED_EMPTY;
            this.v = v;
        }

        public MoodAnalyzerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MoodAnalyzerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}