using log4net.Core;
using log4net.Util;
using System;
using System.Globalization;
using ILogger = Castle.Core.Logging.ILogger;

namespace Log4netDemo.Web.Log4Net
{
    [Serializable]
    public class Log4NetLogger :
            MarshalByRefObject,
            ILogger
    {
        private static readonly Type DeclaringType = typeof(Log4NetLogger);
        
        private log4net.Core.ILogger _logger;
        private Log4NetLoggerFactory _factory;
        public Log4NetLogger()
        {
            _factory = new Log4NetLoggerFactory();
            _logger = _factory.GetLogger("cislog");
        }

        public bool IsDebugEnabled
        {
            get { return _logger.IsEnabledFor(Level.Debug); }
        }

        public bool IsErrorEnabled
        {
            get { return _logger.IsEnabledFor(Level.Error); }
        }

        public bool IsFatalEnabled
        {
            get { return _logger.IsEnabledFor(Level.Fatal); }
        }

        public bool IsInfoEnabled
        {
            get { return _logger.IsEnabledFor(Level.Info); }
        }

        public bool IsWarnEnabled
        {
            get { return _logger.IsEnabledFor(Level.Warn); }
        }



        public override string ToString()
        {
            return _logger.ToString();
        }
        
        public void Debug(string message)
        {
            if (IsDebugEnabled)
            {
                _logger.Log(DeclaringType, Level.Debug, message, null);
            }
        }

        public void Debug(Func<string> messageFactory)
        {
            if (IsDebugEnabled)
            {
                _logger.Log(DeclaringType, Level.Debug, messageFactory.Invoke(), null);
            }
        }

        public void Debug(string message, Exception exception)
        {
            if (IsDebugEnabled)
            {
                _logger.Log(DeclaringType, Level.Debug, message, exception);
            }
        }

        public void DebugFormat(string format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                _logger.Log(DeclaringType, Level.Debug, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), null);
            }
        }

        public void DebugFormat(Exception exception, string format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                _logger.Log(DeclaringType, Level.Debug, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), exception);
            }
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                _logger.Log(DeclaringType, Level.Debug, new SystemStringFormat(formatProvider, format, args), null);
            }
        }

        public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                _logger.Log(DeclaringType, Level.Debug, new SystemStringFormat(formatProvider, format, args), exception);
            }
        }

        public void Error(string message)
        {
            if (IsErrorEnabled)
            {
                _logger.Log(DeclaringType, Level.Error, message, null);
            }
        }

        public void Error(Func<string> messageFactory)
        {
            if (IsErrorEnabled)
            {
                _logger.Log(DeclaringType, Level.Error, messageFactory.Invoke(), null);
            }
        }

        public void Error(string message, Exception exception)
        {
            if (IsErrorEnabled)
            {
                _logger.Log(DeclaringType, Level.Error, message, exception);
            }
        }

        public void ErrorFormat(string format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                _logger.Log(DeclaringType, Level.Error, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), null);
            }
        }

        public void ErrorFormat(Exception exception, string format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                _logger.Log(DeclaringType, Level.Error, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), exception);
            }
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                _logger.Log(DeclaringType, Level.Error, new SystemStringFormat(formatProvider, format, args), null);
            }
        }

        public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                _logger.Log(DeclaringType, Level.Error, new SystemStringFormat(formatProvider, format, args), exception);
            }
        }

        public void Fatal(string message)
        {
            if (IsFatalEnabled)
            {
                _logger.Log(DeclaringType, Level.Fatal, message, null);
            }
        }

        public void Fatal(Func<string> messageFactory)
        {
            if (IsFatalEnabled)
            {
                _logger.Log(DeclaringType, Level.Fatal, messageFactory.Invoke(), null);
            }
        }

        public void Fatal(string message, Exception exception)
        {
            if (IsFatalEnabled)
            {
                _logger.Log(DeclaringType, Level.Fatal, message, exception);
            }
        }

        public void FatalFormat(string format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                _logger.Log(DeclaringType, Level.Fatal, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), null);
            }
        }

        public void FatalFormat(Exception exception, string format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                _logger.Log(DeclaringType, Level.Fatal, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), exception);
            }
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                _logger.Log(DeclaringType, Level.Fatal, new SystemStringFormat(formatProvider, format, args), null);
            }
        }

        public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                _logger.Log(DeclaringType, Level.Fatal, new SystemStringFormat(formatProvider, format, args), exception);
            }
        }

        public void Info(string message)
        {
            if (IsInfoEnabled)
            {
                _logger.Log(DeclaringType, Level.Info, message, null);
            }
        }

        public void Info(Func<string> messageFactory)
        {
            if (IsInfoEnabled)
            {
                _logger.Log(DeclaringType, Level.Info, messageFactory.Invoke(), null);
            }
        }

        public void Info(string message, Exception exception)
        {
            if (IsInfoEnabled)
            {
                _logger.Log(DeclaringType, Level.Info, message, exception);
            }
        }

        public void InfoFormat(string format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                _logger.Log(DeclaringType, Level.Info, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), null);
            }
        }

        public void InfoFormat(Exception exception, string format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                _logger.Log(DeclaringType, Level.Info, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), exception);
            }
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                _logger.Log(DeclaringType, Level.Info, new SystemStringFormat(formatProvider, format, args), null);
            }
        }

        public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                _logger.Log(DeclaringType, Level.Info, new SystemStringFormat(formatProvider, format, args), exception);
            }
        }

        public void Warn(string message)
        {
            if (IsWarnEnabled)
            {
                _logger.Log(DeclaringType, Level.Warn, message, null);
            }
        }

        public void Warn(Func<string> messageFactory)
        {
            if (IsWarnEnabled)
            {
                _logger.Log(DeclaringType, Level.Warn, messageFactory.Invoke(), null);
            }
        }

        public void Warn(string message, Exception exception)
        {
            if (IsWarnEnabled)
            {
                _logger.Log(DeclaringType, Level.Warn, message, exception);
            }
        }

        public void WarnFormat(string format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                _logger.Log(DeclaringType, Level.Warn, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), null);
            }
        }

        public void WarnFormat(Exception exception, string format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                _logger.Log(DeclaringType, Level.Warn, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), exception);
            }
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                _logger.Log(DeclaringType, Level.Warn, new SystemStringFormat(formatProvider, format, args), null);
            }
        }

        public void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                _logger.Log(DeclaringType, Level.Warn, new SystemStringFormat(formatProvider, format, args), exception);
            }
        }

        public ILogger CreateChildLogger(string loggerName)
        {
            throw new NotImplementedException();
        }
    }
}