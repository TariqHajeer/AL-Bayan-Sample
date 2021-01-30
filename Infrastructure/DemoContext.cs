using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Storeak.Demo.Api.Infrastructure.DataModel;
using Storeak.Demo.Api.Infrastructure.Mapping;
using StoreakApiService.Core.Context;

namespace Storeak.Demo.Api.Infrastructure
{
    public class DemoContext : StoreDbContext
    {
        public DemoContext(IHttpContextAccessor accessor)
            : base(accessor)
        {
        }

        public virtual DbSet<EmployeeDto> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMap());

            modelBuilder.Entity<EmployeeDto>().HasQueryFilter(x =>
               EF.Property<long>(x, "StoreId") == Client.StoreId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
