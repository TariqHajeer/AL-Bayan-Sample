using StoreakApiService.Core.Context.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storeak.Demo.Api.Infrastructure.DataModel
{
    public class ItemDto : TrackableDto
    {
        /// <summary>
        /// UPC :Universal Product Code  
        /// </summary>
        public string UPC { get; set; }
        public DateTime? ExpiryDate { get; set; }
        [Column(TypeName = "Money")]
        public decimal BuyPrice { get; set; }
        [Column(TypeName = "Money")]
        public decimal SellPrice { get; set; }
        public Guid CategorieId { get; set; }
        [ForeignKey(nameof(CategorieId))]
        public virtual CategorieDto Categorie { get; set; }
        public int Count { get; set; }
    }
}
