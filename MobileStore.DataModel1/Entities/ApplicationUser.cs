using Microsoft.AspNetCore.Identity;
using MobileStore.DataModelLayer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MobileStore.DataModelLayer1.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [Display(Name = "ناریخ ثبت نام")]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "وضعیت دسترسی")]
        public bool IsActive { get; set; }

        public virtual ICollection<InvoiceEntity> Invoice { get; set; }
    }
}
