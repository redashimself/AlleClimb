using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace AlleClimb;

public class AlleClimbWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<AlleClimbWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
