using SoftUniLogger.Appenders.Interfaces;
using SoftUniLogger.Layouts.Interfaces;
using SoftUniLogger.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogger.Appenders
{
    public class FileAppender : IAppender
    {
        private ILayout _layout;
        private ILayout simpleLayout;

        public FileAppender(ILayout layout)
        {
            _layout = layout;
        }
        public FileAppender(ILayout layout, string filePath) : this (layout)
        { 
        FilePath=filePath;
        }
        public string FilePath { get; set; } = 
            $"..\\..\\..\\{DateTime.Now:yyyyMMddhhmmss}.txt";

        public LogEntryLevel LogLevel { get; set; } = 0;
        public void Append(Message message)
        {
           string formattedLogEntry=_layout.Format(message);
            try
            {
                // File manages the streams for us
                File.AppendAllText(FilePath, formattedLogEntry + Environment.NewLine);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
