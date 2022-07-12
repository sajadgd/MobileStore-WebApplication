using MobileStore.DataModelLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MobileStore.DataModelLayer1.Models
{
    public class MenuEntity
    {
        [Key]
        public int MenuID { get; set; }
        public string MenuTitle { get; set; }
        public int CateId { get; set; } // FK

        //////////////////////////
        /// <summary>
        /// 
        /// </summary>
        /// 

        [ForeignKey("CateId")]
        public virtual CategoriesEntity Categories { get; set; }

        ////////////////////////////
        ///

        public ICollection<ProductEntity> Product { get; set; }
    }
}
