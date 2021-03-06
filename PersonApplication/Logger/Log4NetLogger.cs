﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using log4net.Core;
using log4net.Repository;

namespace PersonApplication.Logger
{
    public class Log4NetLogger : ILogger
    {

        private ILog _logger;

        public string Name => throw new NotImplementedException();

        public ILoggerRepository Repository => throw new NotImplementedException();

        public Log4NetLogger()
        {
            _logger = LogManager.GetLogger(this.GetType());
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        //public void Error(Exception x)
        //{
        //    Error(LogUtility.BuildExceptionMessage(x));
        //}

        public void Error(string message, Exception x)
        {
            _logger.Error(message, x);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        //public void Fatal(Exception x)
        //{
        //    Fatal(LogUtility.BuildExceptionMessage(x));
        //}

        public void Log(Type callerStackBoundaryDeclaringType, Level level, object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Log(LoggingEvent logEvent)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabledFor(Level level)
        {
            throw new NotImplementedException();
        }
    }
}