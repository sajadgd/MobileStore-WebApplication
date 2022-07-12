using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileStore.DataModelLayer.Models;
using MobileStore.DataModelLayer1.Models;

namespace MobileStore.CommandLayer1.ViewModel
{
    public class ProductDetailViewModel
    {
        public string Product_ProName { get; set; }
        public int Product_Mojodi { get; set; }
        public double Product_Mablagh  { get; set; }
        public double Product_Takhfif  { get; set; }
        public string Product_TozihKotah  { get; set; }
        public string Product_TozihKamel  { get; set; }

        public List<ProductDetailEntity> LstProductDetail { get; set; }

        public List<ProductGalleryEntity> LstProductGallery { get; set; }
    }
}
