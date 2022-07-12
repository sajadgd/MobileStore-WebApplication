using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobileStore.DataModelLayer1.Models
{
    public class SliderEntity
    {
        [Key]
        public int SliderID { get; set; }

        [Display(Name = "عنوان اسلایدر")]
        [Required]
        public string SliderTitle { get; set; }

        [Display(Name = "لینک اسلایدر")]
        [Required]
        public string SliderLink { get; set; }

        [Display(Name = "اولویت اسلایدر")]
        [Required]
        public int SliderPrority { get; set; }

        [Display(Name = "تصویر اسلایدر")]
        [Required]
        public string SliderImage { get; set; }

        [Display(Name = "وضعیت نمایش اسلایدر")]
        [Required]
        public bool SliderIsActive { get; set; }
    }
}
