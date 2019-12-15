using System;

namespace PerfectOnion.Core.Exceptions
{
    public class ConfigurationException : Exception
    {
        public ConfigurationException(string errorMessage): base(errorMessage)
        {
        }
    }
}