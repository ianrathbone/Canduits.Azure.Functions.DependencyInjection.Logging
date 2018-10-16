# Canduits.Azure.Functions.DependencyInjection.Logging
A working functions logging solution to get around the filtering of ILogger when the name doesn't match Function.Class or Function.Class.User

![Azure Pipeline Build Status](https://ianrathbone.visualstudio.com/Open%20Source/_apis/build/status/Build%20and%20Publish%20Canduits%20Functions%20DI%20Logging%20Package-clone "Azure Pipeline Build Status")

Example usage:
### Function Declaration using a defined interface
```C#
using System;
using Canduits.Azure.Functions.DependencyInjection.Logging

namespace my.new.function
{
    public class Stuff : IStuff
    {
        private readonly IFunctionLogger _logger;

        public void Stuff(IFunctionLogger logger)
        {
            _logger = logger;
        }

        public bool DoSomething()
        {
            _logger.LogInformation("Something happened!!");
        }
    }
}
```

### Basic Setup in Startup.cs
```C#
using System;
using Canduits.Azure.Functions.DependencyInjection;
using Canduits.Azure.Functions.DependencyInjection.Logging;
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
