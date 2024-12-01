using Microsoft.Extensions.Logging;
using Quartz;

namespace Pinguin.Maui.Jobs;

public class PingJob : IJob
{
    public const string JobName = "PingJob";
    private readonly ILogger<PingJob> _logger;

    public PingJob(
        ILogger<PingJob> logger
    )
    {
        _logger = logger;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        _logger.LogInformation("Executing PingJob");
    }
}
