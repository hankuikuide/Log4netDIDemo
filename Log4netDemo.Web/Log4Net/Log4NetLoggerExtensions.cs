using Castle.Core.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Log4netDemo.Web.Log4Net
{
    public static class Log4NetLoggerExtensions
    {
        public static IServiceCollection UseExceptionless(this IServiceCollection services)
        {
            services.AddTransient<ILogger, Log4NetLogger>();

            return services;
        }
    }
}
