# Canduits.Azure.Functions.DependencyInjection.Logging
A working functions logging solution to get around the filtering of ILogger when the name doesn't match Function.Class or Function.Class.User

Example usage:
### Basic Setup in Startup.cs
```C#
using System;
using Canduits.Azure.Functions.DependencyInjection;
using Canduits.Azure.Functions.DependencyInjection.Logging
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: WebJobsStartup(typeof(Startup), "Startup")]
namespace my.new.function
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.Services.AddFunctionLogging();
        }
    }
}

```