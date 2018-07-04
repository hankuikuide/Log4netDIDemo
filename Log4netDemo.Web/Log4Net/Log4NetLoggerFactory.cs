using System;
using System.IO;
using System.Reflection;
using System.Xml;
using Castle.Core.Logging;
using log4net;
using log4net.Config;
using log4net.Repository;

namespace Log4netDemo.Web.Log4Net
{
    public class Log4NetLoggerFactory : AbstractLoggerFactory
    {
        internal const string DefaultConfigFileName = "log4net.config";
        private readonly ILoggerRepository _loggerRepository;

        public Log4NetLoggerFactory()
            : this(DefaultConfigFileName)
        {
        }

        public Log4NetLoggerFactory(string configFileName)
        {
            _loggerRepository = LogManager.CreateRepository(
                typeof(Log4NetLoggerFactory).GetAssembly(),
                typeof(log4net.Repository.Hierarchy.Hierarchy)
            );
            
            XmlConfigurator.Configure(_loggerRepository, new FileInfo("log4net.config"));
        }

        public log4net.Core.ILogger GetLogger(string name)
        {
            return LogManager.GetLogger(_loggerRepository.Name, name).Logger;
        }

        public override ILogger Create(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return new Log4NetLogger();
        }

        public override ILogger Create(string name, LoggerLevel level)
        {
            throw new NotSupportedException("Logger levels cannot be set at runtime. Please review your configuration file.");
        }
    }

    public static class TypeExtensions
    {
        public static Assembly GetAssembly(this Type type)
        {
            return type.GetTypeInfo().Assembly;
        }
    }
}