using MobileStore.DataModelLayer.Models;
using MobileStore.DataModelLayer1.Entities;
using MobileStore.DataModelLayer1.Models;
using MobileStore.DataModelLayer1.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore1.CommandLayer1.Services
{
    public interface IUnitOfWork
    {
        GenericClass<SliderEntity> SliderUW { get; }
        GenericClass<ProductEntity> ProductUW { get; }
        GenericClass<ProductGalleryEntity> ProductGalleryUW { get; }
        GenericClass<NewsEntity> NewsUW { get; }
        GenericClass<SettingsEntity> SettingsUW { get; }
        GenericClass<CategoriesEntity> CategoriesUW { get; }
        GenericClass<MenuEntity> MenuUW { get; }
        GenericClass<InvoiceEntity> InvoiceUW { get; }
        GenericClass<ApplicationUser> ApplicationUserUW { get; }
        GenericClass<ApplicationRole> ApplicationRoleUW { get; }
        GenericClass<ProductDetailEntity> ProductDetailUW { get; }

    }
}
