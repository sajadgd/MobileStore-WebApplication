using MobileStore.CommandLayer1.ViewModel.Site;
using MobileStore.DataModelLayer1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.CommandLayer1.ViewModel
{
    public class HomeViewModel
    {
        public List<SliderEntity> ListSlider { get; set; }
        public List<InexpensiveViewModel> Inexpensive { get; set; }
        public List<InexpensiveViewModel> ProductNew { get; set; }
        public List<InexpensiveViewModel> BestSellingProduct { get; set; }
        public List<NewsViewModel> NewsPicture { get; set; }
    }
}
