using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobileStore.CommandLayer1.ViewModel;
using MobileStore.DataModelLayer.Models;
using MobileStore.DataModelLayer1.Models;
using MobileStore1.CommandLayer1.Services;

namespace MobileStore.CommandLayer1.Services
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly IUnitOfWork _IUOW;

        public ProductDetailService(IUnitOfWork IUOW)
        {
            _IUOW = IUOW;
        }

        private List<ProductGalleryEntity> LstProGallery(int Id)
        {
            return _IUOW.ProductGalleryUW.Get(m => m.ProductGallery_ProductId.Equals(Id)).ToList();
        }
        private List<ProductDetailEntity> LstProDetail(int Id)
        {
            return _IUOW.ProductDetailUW.Get(m => m.ProductDetail_ProductId.Equals(Id)).ToList();
        }

        public ProductDetailViewModel ProDetail(int Id)
        {
            ProductDetailViewModel detailViewModel = new ProductDetailViewModel();

            var model = _IUOW.ProductUW.Get(g => g.Product_IsAccept.Equals(true) && g.Product_Id.Equals(Id))
                .FirstOrDefault();

            detailViewModel.Product_ProName = model.Product_ProName;
            detailViewModel.Product_Mojodi = model.Product_Mojodi;
            detailViewModel.Product_Mablagh = model.Product_Mablagh;
            detailViewModel.Product_Takhfif = model.Product_Takhfif;
            detailViewModel.Product_TozihKotah = model.Product_TozihKotah;
            detailViewModel.Product_TozihKamel = model.Product_TozihKamel;

            detailViewModel.LstProductGallery = LstProGallery(Id);
            detailViewModel.LstProductDetail = LstProDetail(Id);

            return detailViewModel;
        }

 
    }
}
