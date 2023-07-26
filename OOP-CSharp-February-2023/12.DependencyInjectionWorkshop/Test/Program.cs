using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()

    .BuildServiceProvider();

//configure console logging
serviceProvider
    .GetService<Program>();
var logger = serviceProvider.GetService<ILoggerFactory>()
    .CreateLogger<Program>();
logger.LogDebug("Starting application");

//do the actual work here
var bar = serviceProvider.GetService<IBarService>();
bar.DoSomeRealWork();

logger.LogDebug("All done!");