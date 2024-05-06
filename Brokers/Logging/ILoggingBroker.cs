using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Register.Brokers.Logging
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogError(string userMessage);
    }
}