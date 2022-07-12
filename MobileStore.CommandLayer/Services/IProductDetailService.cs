using System;
using System.Collections.Generic;
using System.Text;
using MobileStore.CommandLayer1.ViewModel;

namespace MobileStore.CommandLayer1.Services
{
    public interface IProductDetailService
    {
        ProductDetailViewModel ProDetail(int Id);
    }
}
