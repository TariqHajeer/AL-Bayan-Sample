using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Storeak.Demo.Api.Infrastructure.DataModel;
using StoreakApiService.Core.Context.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storeak.Demo.Api.Infrastructure.Mapping
{
    public class CategorieMap : TrackableMap<CategorieDto>
    {
        public override void Configure(EntityTypeBuilder<CategorieDto> builder)
        {
            builder.Property(c => c.Name).IsRequired(true).HasColumnName("Name");
            builder.Property(c => c.CategorieId).IsRequired(false).HasColumnName("CategorieId");

            base.Configure(builder);
            builder.ToTable("Categories");
        }
    }
}
