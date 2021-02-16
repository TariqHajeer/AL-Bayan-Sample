using StoreakApiService.Core.Context.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Storeak.Demo.Api.Infrastructure.DataModel
{
    public class CategorieDto : TrackableDto
    {
        public string Name { get; set; }
        public Guid? CategorieId { get; set; }
        [ForeignKey(nameof(CategorieId))]
        public virtual CategorieDto Categorie { get; set; }
        public virtual IList<CategorieDto> Categories { get; set; }
    }
}
