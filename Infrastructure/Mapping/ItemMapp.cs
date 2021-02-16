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
    public class ItemMapp : TrackableMap<ItemDto>
    {
        public override void Configure(EntityTypeBuilder<ItemDto> builder)
        {
            builder.Property(c => c.ExpiryDate).IsRequired(false);
            builder.HasIndex(c => c.UPC).IsUnique(true);
            builder.Property(c => c.UPC).IsRequired(true);
            base.Configure(builder);
            builder.ToTable("Items");
        }
    }
}
