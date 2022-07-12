using MobileStore.DataModelLayer.Utilities;
using MobileStore.DataModelLayer1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MobileStore.DataModelLayer.Models;

namespace MobileStore.DataModelLayer1.Models
{
    public class ProductDetailEntity
    {

        [Key]
        public int ProductDetail_Id { get; set; }

        [Display(Name = "نام مشخصه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        public string ProductDetail_AttName { get; set; }

        [Display(Name = "مقدار مشخصه")]
        public string ProductDetail_AttValue { get; set; }

        public int ProductDetail_ProductId { get; set; } //FK

        [ForeignKey("ProductDetail_ProductId")]
        public virtual ProductEntity Product { get; set; }
    }
}
