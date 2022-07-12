using MobileStore.CommandLayer1.Services;
//using MobileStore1.Data;
using MobileStore.DataModelLayer1.Models;
using MobileStore.DataModelLayer1.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using MobileStore1.CommandLayer1.Services;
using MobileStore.DataModelLayer1.Data;
using MobileStore.DataModelLayer.Models;
using MobileStore.DataModelLayer1.Entities;

namespace MobileStore.CommandLayer1.Services
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <SliderEntity>
        /// //////////////////////////////////////////////////////////////////////////////////////  


        private GenericClass<SliderEntity> _SliderUW;

        public GenericClass<SliderEntity> SliderUW
        {
            get
            {
                if (_SliderUW == null)
                {
                    _SliderUW = new GenericClass<SliderEntity>(_context);
                }

                return _SliderUW;
            }
        }

        //<ProductEntity>////////////////////////////////////////////////////////////////////////////////

        private GenericClass<ProductEntity> _productUW;

        public GenericClass<ProductEntity> ProductUW
        {
            get
            {
                if (_productUW == null)
                {
                    _productUW = new GenericClass<ProductEntity>(_context);
                }

                return _productUW;
            }
        }

        //<ProductGalleryEntity>//////////////////////////////////////////////////////////////

        private GenericClass<ProductGalleryEntity> _productGalleryUW;

        public GenericClass<ProductGalleryEntity> ProductGalleryUW
        {
            get
            {
                if (_productGalleryUW == null)
                {
                    _productGalleryUW = new GenericClass<ProductGalleryEntity>(_context);
                }

                return _productGalleryUW;
            }
        }

        ///<NewsEntity>/////////////////////////////////////////
        ///

        private GenericClass<NewsEntity> _newsUW;

        public GenericClass<NewsEntity> NewsUW
        {
            get
            {
                if (_newsUW == null)
                {
                    _newsUW = new GenericClass<NewsEntity>(_context);
                }

                return _newsUW;
            }
        }

        /// <summary>
        /// //////////////////////////////////////////
        /// </summary>

        private GenericClass<SettingsEntity> _settingsUW;

        public GenericClass<SettingsEntity> SettingsUW
        {
            get
            {
                if (_settingsUW == null)
                {
                    _settingsUW = new GenericClass<SettingsEntity>(_context);
                }

                return _settingsUW;
            }
        }

        /// <summary>
        /// ///////////////////////////////////
        /// </summary>

        private GenericClass<CategoriesEntity> _categoriesUW;

        public GenericClass<CategoriesEntity> CategoriesUW
        {
            get
            {
                if (_categoriesUW == null)
                {
                    _categoriesUW = new GenericClass<CategoriesEntity>(_context);
                }

                return _categoriesUW;
            }
        }

        /// <summary>
        /// //////////////////////////////////////
        /// </summary>

        private GenericClass<MenuEntity> _menuUW;

        public GenericClass<MenuEntity> MenuUW
        {
            get
            {
                if (_menuUW == null)
                {
                    _menuUW = new GenericClass<MenuEntity>(_context);
                }

                return _menuUW;
            }
        }
        /// <summary>
        /// ////////////////////////////////////////////
        /// </summary>
        private GenericClass<InvoiceEntity> _invoiceUW;

        public GenericClass<InvoiceEntity> InvoiceUW
        {
            get
            {
                if (_invoiceUW == null)
                {
                    _invoiceUW = new GenericClass<InvoiceEntity>(_context);
                }
                return _invoiceUW;
            }
        }

        /// <summary>
        /// ////////////////////////////////////////////////
        /// </summary>

        private GenericClass<ApplicationUser> _appUserUW;

        public GenericClass<ApplicationUser> ApplicationUserUW
        {
            get
            {
                if (_appUserUW == null)
                {
                    _appUserUW = new GenericClass<ApplicationUser>(_context);
                }
                return _appUserUW;
            }
        }

        /// <summary>
        /// ////////////////////////////////////////////////////
        /// </summary>

        private GenericClass<ApplicationRole> _appRoleUW;

        public GenericClass<ApplicationRole> ApplicationRoleUW
        {
            get
            {
                if (_appRoleUW == null)
                {
                    _appRoleUW = new GenericClass<ApplicationRole>(_context);
                }
                return _appRoleUW;
            }
        }

        /// <summary>
        /// //////////////////////////////////////////////////////
        /// </summary>

        private GenericClass<ProductDetailEntity> _productDetailUW;

        public GenericClass<ProductDetailEntity> ProductDetailUW
        {
            get
            {
                if (_productDetailUW == null)
                {
                    _productDetailUW = new GenericClass<ProductDetailEntity>(_context);
                }
                return _productDetailUW;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}