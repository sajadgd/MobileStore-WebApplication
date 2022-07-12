using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobileStore.CommandLayer1.ViewModel;
using MobileStore1.CommandLayer1.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MobileStore.CommandLayer1.Services;

namespace MobileStore1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IUnitOfWork _IUOW;
        private readonly IProductDetailService _IPDS;

        public ProductController(ILogger<ProductController> logger, IUnitOfWork IUOW , IProductDetailService IPDS)
        {
            _logger = logger;
            _IUOW = IUOW;
            _IPDS = IPDS;
        }
        public IActionResult ProductDetail(int Id)
        {
            var model = _IPDS.ProDetail(Id);

            return View(model);
        }
    }
}
