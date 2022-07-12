using MobileStore.DataModelLayer.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobileStore.DataModelLayer1.Models
{
    public class NewsEntity
    {
        [Key]
        public int News_Id { get; set; }

        [Display(Name = "عنوان خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        [MinLength(5, ErrorMessage = ErrorMessage.MinLenghtMsg)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessage = ErrorMessage.RegExpMsg)]
        public string News_Title { get; set; }

        [Display(Name = "نوضیحات خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        [MaxLength(500, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        [MinLength(30, ErrorMessage = ErrorMessage.MinLenghtMsg)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessage = ErrorMessage.RegExpMsg)]
        public string News_Description { get; set; }

        [Display(Name = "تصویر خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
        public string News_Image { get; set; }

        [Display(Name = " تایید خبر ")]
        public bool News_IsAccept { get; set; }

        [Display(Name = " زمان ثبت خبر ")]
        [DataType(DataType.Date)]
        public DateTime News_RegistrationTime { get; set; }
    }
}
