using Microsoft.Extensions.Logging;
using Pinguin.Maui.Jobs;
using Quartz;

namespace Pinguin.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddQuartz(q =>
        {
            q.AddJob<PingJob>(cfg => cfg
                .WithIdentity(PingJob.JobName)
                .StoreDurably());
        });

        builder.Services.AddQuartzHostedService(opt => opt.WaitForJobsToComplete = true);

        return builder.Build();
    }
}
