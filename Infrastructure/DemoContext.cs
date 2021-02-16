
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
        public virtual DbSet<CategorieDto> Categories{ get; set; }
        public virtual DbSet<ItemDto> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            modelBuilder.ApplyConfiguration(new CategorieMap());
            modelBuilder.ApplyConfiguration(new ItemMapp());
            modelBuilder.Entity<EmployeeDto>().HasQueryFilter(x =>
               EF.Property<long>(x, "StoreId") == Client.StoreId);
            modelBuilder.Entity<CategorieDto>().HasQueryFilter(x =>
               EF.Property<long>(x, "StoreId") == Client.StoreId);
            modelBuilder.Entity<ItemDto>().HasQueryFilter(x =>
               EF.Property<long>(x, "StoreId") == Client.StoreId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
