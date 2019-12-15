using System;

namespace PerfectOnion.Core.Common.Exceptions
{
    public class ConfigurationException : Exception
    {
        public ConfigurationException(string errorMessage): base(errorMessage)
        {
        }
    }
}