using SoftUniLogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogger.Appenders.Interfaces
{
    public interface IAppender
    {
        void Append(Message message);
        LogEntryLevel LogLevel { get; set; }
        
    }
}
