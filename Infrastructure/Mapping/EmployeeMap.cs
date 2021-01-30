using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Storeak.Demo.Api.Infrastructure.DataModel;
using StoreakApiService.Core.Context.Mapping;

namespace Storeak.Demo.Api.Infrastructure.Mapping
{
    public class EmployeeMap : TrackableMap<EmployeeDto>
    {
        public override void Configure(EntityTypeBuilder<EmployeeDto> builder)
        {
            builder.Property(c => c.Name).IsRequired(true).HasColumnName("Name");
            builder.Property(c => c.FatherName).IsRequired(false).HasColumnName("FatherName");
            builder.Property(c => c.Age).IsRequired(true).HasColumnName("Age");
            builder.Property(c => c.Type).IsRequired(true).HasColumnName("Type");

            base.Configure(builder);
            builder.ToTable("Employees");
        }
    }
}
