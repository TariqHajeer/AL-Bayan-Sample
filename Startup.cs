using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Storeak.Demo.Api.Application;
using Storeak.Demo.Api.Application.BusinessUseCases.Employee;
using Storeak.Demo.Api.Application.Queries.Employee;
using Storeak.Demo.Api.Infrastructure;
using StoreakApiService.Core.Helper;
using StoreakApiService.Core.Projects;
using StoreakApiService.Core.Responses;

namespace Storeak.Demo.Api
{
    public class Startup : StoreakApiService.Core.Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
            : base(configuration, env)
        {
            ApiProjectSettings.ProjectId = ProjectNames.demo;
            ApiProjectSettings.UseSession = true;
            ApiProjectSettings.Databasename = "StoreakDemo";

            ApiProjectSettings.EnvironmentType = ProjectEnvironmentType.LocalHost;
            ApiProjectSettings.UsePostFix = false;
            ApisUrl.LoadUrls(ProjectEnvironmentType.TestProduction);
            ApiProjectSettings.UseCache = false;
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            // Auto Mapper Configurations
            base.ConfigureAutoMapper(services, new MapperProfile());

            // Services DI
            services.AddScoped<UnitOfWork>();

            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddScoped<EmployeeQueries>();

            // Responses DI
            services.AddSingleton<IResponseMessages, ResponseMessages>();

            // DBContext Intialization with connection string
            base.ConfigureDatabase<DemoContext>(services);
        }
    }
}
