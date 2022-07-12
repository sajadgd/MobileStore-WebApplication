using MobileStore.DataModelLayer.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.DataModelLayer.Models
{
    public class ProductGalleryEntity
    {
        [Key]
        public int ProductGallery_Id { get; set; }

        public string ProductGallery_Name { get; set; }

        public int ProductGallery_ProductId { get; set; } //کلید خارجی

        public bool ProductGallery_Default { get; set; }

        // کلید های خارجی

        [ForeignKey(nameof(ProductGallery_ProductId))]
        public virtual ProductEntity ProductEntity { get; set; }
    }
}
