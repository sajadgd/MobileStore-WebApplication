# MobileStore-WebApplication
پروژه فروشگاه موبایل تحت وب توسعه یافته بواسطه ASP.NET Core
معماری این پروژه بصورت سه لایه میباشد که شامل :
MobileStore1 : لایه بیرونی پروژه که شامل EndPoint سایت و سایر بخش هایی که با کاربر ارتباط دارند.
MobileStore.DataModel1 : عمیق ترین لایه پروژه که شامل DatabaseContext که به پایگاه داده متصل میشود . Entitiies که شامل کلاس های مربوط به پروژه میباشد که بصورت جدول بندی شده به پایگاه داده فرستاده میشود و Business Logic های پروژه نیز در این لایه نگهداری میشود .
MobileStore.CommandLayer : این لایه با استفاده از الگوی UnitOfWork بعنوان واسط بین لایه کاربری و دیتا مدل عمل میکند همچنین در این لایه Service های مربوط به کاربران پیاده سازی میشود و ViewModel ها هم در این لایه نگهداری میشود