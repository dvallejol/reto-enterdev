using Microsoft.Extensions.DependencyInjection;
using Reto.Payment.BL.BL.FacturaBL;
using Reto.Payment.BL.InvoiceBL;
using Reto.Payment.BL.ProductsBL;
using Reto.Payment.DAL.DAL.FacturaDAL;
using Reto.Payment.DAL.Generic;
using Reto.Payment.DAL.Interfaces;
using Reto.Payment.DAL.InvoiceDAL;
using Reto.Payment.DAL.ProductsDAL;
using Reto.Payment.Models;
using Reto.Payment.Models.Models;

namespace Reto.Payment.API.Extension
{
    public static class ServicesInjection
    {
        public static void AddServices(this IServiceCollection services)
        {

            services.AddTransient<IUnitOfWork<Products>, UnitOfWork<Products>>();

            services.AddTransient<IProductsServiceBL, ProductsServiceBL>();

            services.AddTransient<IProductsDAL, ProductsDAL>();

            services.AddTransient<IUnitOfWork<Factura>, UnitOfWork<Factura>>();
             
            services.AddTransient<IFacturaServiceBL, FacturaServiceBL>();

            services.AddTransient<IFacturaDAL, FacturaDAL>();

            services.AddTransient<IUnitOfWork<Invoice>, UnitOfWork<Invoice>>();

            services.AddTransient<IInvoiceServiceBL, InvoiceServiceBL>();

            services.AddTransient<IInvoiceDAL, InvoiceDAL>();

        }

    }
}
