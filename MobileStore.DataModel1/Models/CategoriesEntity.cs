using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobileStore.DataModelLayer1.Models
{
    public class CategoriesEntity
    {
        [Key]
        public int CategoriesID { get; set; }
        public string CategoriesTitle { get; set; }
        public int CategoriesParentId { get; set; }

        ////////////////////////////////////
        ///

        public ICollection<MenuEntity> Menu { get; set; }
    }
}
