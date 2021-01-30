using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using StoreakApiService.Core.Projects;

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
        }
    }
}
