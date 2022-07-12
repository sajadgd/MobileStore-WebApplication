using MobileStore.DataModelLayer.Utilities;
using MobileStore.DataModelLayer1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.DataModelLayer.Models
{
    public class ProductEntity
    {
        [Key]
        public int Product_Id { get; set; }

        [Display(Name = "نام محصول")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        [MinLength(5, ErrorMessage = ErrorMessage.MinLenghtMsg)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessage = ErrorMessage.RegExpMsg)]
        public string Product_ProName { get; set; }

        [Display(Name = "نام انگلیسی محصول")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        [MinLength(5, ErrorMessage = ErrorMessage.MinLenghtMsg)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessage = ErrorMessage.RegExpMsg)]
        public string Product_NameEn { get; set; }

        [Display(Name = "توضیحات مختصر ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        [MaxLength(150, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        [MinLength(10, ErrorMessage = ErrorMessage.MinLenghtMsg)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessage = ErrorMessage.RegExpMsg)]
        public string Product_TozihKotah { get; set; }

        [Display(Name = "توضیحات کامل ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        public string Product_TozihKamel { get; set; }

        [Display(Name = "کد محصول")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        [MaxLength(10, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string Product_Code { get; set; }

        [Display(Name = "تعداد بازدید")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        public int Product_Bazdid { get; set; }

        [Display(Name = " موجودی ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        public int Product_Mojodi { get; set; }

        [Display(Name = " درصد تخفیف ")]
        public double Product_Takhfif { get; set; }

        [Display(Name = " زمان ثبت ")]
        [DataType(DataType.Date)]
        public DateTime Product_ZamanSabt { get; set; }

        [Display(Name = " قیمت محصول ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        public double Product_Mablagh { get; set; }

        [Display(Name = " زیر منو ")]
        public int Product_MenuId { get; set; }//کلید خارجی

        [Display(Name = " تایید محصول ")]
        public bool Product_IsAccept { get; set; }

        // کلید های خارجی

        [ForeignKey(nameof(Product_MenuId))]
        public virtual MenuEntity Menu { get; set; }

        //---------------------- جدول های مرتبط

        public virtual ICollection<ProductGalleryEntity> ProductGallery { get; set; }

        public virtual ICollection<InvoiceEntity> Invoice { get; set; }

        public virtual ICollection<ProductDetailEntity> ProductDetail { get; set; }
    }
}
