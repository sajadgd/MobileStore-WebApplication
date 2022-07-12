using MobileStore.DataModelLayer.Utilities;
using MobileStore.DataModelLayer1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.DataModelLayer.Models
{
    public class InvoiceEntity
    {
        [Key]
        public int Invoice_Id { get; set; }

        [Display(Name = "شناسه محصول")]
        public int Invoice_ProductId { get; set; } // FK

        [Display(Name = "تعداد محصول")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        public int Invoice_ProductNum { get; set; }

        [Display(Name = "مبلغ مالیات")]
        public long Invoice_TaxAmount { get; set; }

        [Display(Name = "هزینه ارسال")]
        public long Invoice_TransportCost { get; set; }

        [Display(Name = "جمع تخفیف")]
        public long Invoice_Discount { get; set; }

        [Display(Name = "جمع کل خرید")]
        public long Invoice_BuyTotalSum { get; set; }

        [Display(Name = "شناسه سفارش")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        public int Invoice_InvoiceNo { get; set; }

        [Display(Name = "مبلغ قابل پرداخت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        public int Invoice_FinalAmount { get; set; }

        [Display(Name = "زمان ثبت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        public DateTime Invoice_DateTime { get; set; }

        [Display(Name = "شناسه خریدار")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        public string Invoice_BuyerUserId { get; set; } // FK

        [Display(Name = "وضعیت پرداخت")]
        public bool Invoice_PaymentStatus { get; set; }

        [Display(Name = "شناسه تراکنش")]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string Invoice_TransationId { get; set; }

        [Display(Name = "شناسه مرجع")]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string Invoice_RefrenceId { get; set; }

        [ForeignKey("Invoice_BuyerUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("Invoice_ProductId")]
        public virtual ProductEntity Product { get; set; }
    }
}
