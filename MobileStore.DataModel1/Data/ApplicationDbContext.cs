using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MobileStore.DataModelLayer.Models;
using MobileStore.DataModelLayer1.Entities;
using MobileStore.DataModelLayer1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileStore.DataModelLayer1.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser ,ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SliderEntity> Tbl_Slider { get; set; }
        public DbSet<ProductEntity> Tbl_Product { get; set; }
        public DbSet<ProductGalleryEntity> Tbl_ProductGallery { get; set; }
        public DbSet<NewsEntity> Tbl_News { get; set; }
        public DbSet<SettingsEntity> Tbl_Settings { get; set; }
        public DbSet<CategoriesEntity> Tbl_Categories { get; set; }
        public DbSet<MenuEntity> Tbl_Menu { get; set; }
        public DbSet<InvoiceEntity> Tbl_Invoice { get; set; }
        public DbSet<ProductDetailEntity> Tbl_ProductDetail { get; set; }
    }
}
