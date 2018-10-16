﻿using System;
using Microsoft.Extensions.Logging;

namespace Canduits.Azure.Functions.DependencyInjection.Logging
{
    public class FunctionLogger : IFunctionLogger
    {
        private readonly ILogger _logger;

        public FunctionLogger(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("Function." + typeof(FunctionLogger).FullName + ".User");
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
            Func<TState, Exception, string> formatter)
        {
            _logger.Log(logLevel, eventId, state, exception, formatter);
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return _logger.IsEnabled(logLevel);
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return _logger.BeginScope(state);
        }
    }
}