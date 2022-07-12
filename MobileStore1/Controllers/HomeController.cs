using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobileStore.CommandLayer1.ViewModel;
using MobileStore1.CommandLayer1.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _IUOW;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork IUOW)
        {
            _logger = logger;
            _IUOW = IUOW;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();

            model.ListSlider = _IUOW.SliderUW.Get().ToList();

            //////// The Best

            var ListProduct = _IUOW.ProductUW.Get(m => m.Product_Takhfif >= 30 & m.Product_Takhfif <= 70 & m.Product_IsAccept.Equals(true), n => n.OrderByDescending(o => o.Product_Id), "").ToList().Take(2);

            List<InexpensiveViewModel> lstexp = new List<InexpensiveViewModel>();

            foreach (var item in ListProduct)
            {
                InexpensiveViewModel expvm = new InexpensiveViewModel();

                expvm.NameFa = item.Product_ProName;
                expvm.DarsadTakhfif = item.Product_Takhfif;
                expvm.Mablagh = item.Product_Mablagh;

                var Img = _IUOW.ProductGalleryUW.Get(m => m.ProductGallery_ProductId.Equals(item.Product_Id) & m.ProductGallery_Default.Equals(true)).FirstOrDefault();

                if (Img != null)
                {
                    expvm.IndexImage = Img.ProductGallery_Name;
                }
                else
                {
                    expvm.IndexImage = "Noimg.jpg";
                }

                lstexp.Add(expvm);
            }

            model.Inexpensive = lstexp;

            /////////////////////////NewProduct/////////////////////////////////////////
            ///
            var ListNewProduct = _IUOW.ProductUW.Get(m => m.Product_IsAccept.Equals(true), n => n.OrderByDescending(o => o.Product_Id), "").ToList().Take(2);

            List<InexpensiveViewModel> lstnewexp = new List<InexpensiveViewModel>();

            foreach (var item in ListNewProduct)
            {
                InexpensiveViewModel exnewpvm = new InexpensiveViewModel();

                exnewpvm.Id = item.Product_Id;
                exnewpvm.NameFa = item.Product_ProName;
                exnewpvm.Mablagh = item.Product_Mablagh;

                var Img = _IUOW.ProductGalleryUW.Get(m => m.ProductGallery_ProductId.Equals(item.Product_Id) & m.ProductGallery_Default.Equals(true)).FirstOrDefault();

                if (Img != null)
                {
                    exnewpvm.IndexImage = Img.ProductGallery_Name;
                }
                else
                {
                    exnewpvm.IndexImage = "Noimg.jpg";
                }

                lstnewexp.Add(exnewpvm);
            }

            model.ProductNew = lstnewexp;

            /////////////////////////////////////////////
            /// Best Selling //////////////////////////////

            var ListInt = _IUOW.InvoiceUW.Get(m => m.Invoice_PaymentStatus.Equals(true),null , "").GroupBy(g => g.Invoice_ProductId).Select(g => new {ProductId = g.Key , CountProduct = g.Sum(x => x.Invoice_ProductNum)}).OrderByDescending(o => o.CountProduct).Take(8);
            

            List<InexpensiveViewModel> lstsellexp = new List<InexpensiveViewModel>();

            foreach (var item in ListInt)
            {
                var pro = _IUOW.ProductUW.Get(m => m.Product_Id.Equals(item.ProductId)).FirstOrDefault();

                InexpensiveViewModel exsellpvm = new InexpensiveViewModel();

                exsellpvm.NameFa = pro.Product_ProName;
                exsellpvm.Mablagh = pro.Product_Mablagh;

                var Img = _IUOW.ProductGalleryUW.Get(m => m.ProductGallery_ProductId.Equals(pro.Product_Id) & m.ProductGallery_Default.Equals(true)).FirstOrDefault();

                if (Img != null)
                {
                    exsellpvm.IndexImage = Img.ProductGallery_Name;
                }
                else
                {
                    exsellpvm.IndexImage = "Noimg.jpg";
                }

                lstsellexp.Add(exsellpvm);
            }

            model.BestSellingProduct = lstsellexp;

            ////////////////////////////////////////////////////////////

            var set = _IUOW.SettingsUW.Get().FirstOrDefault();

            ViewBag.metakey = set.Settings_MetaKeyword;
            ViewBag.metadesc = set.Settings_Description;


            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
