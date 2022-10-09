using Reto.Payment.BL.Generic;
using Reto.Payment.DAL.Interfaces;
using Reto.Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reto.Payment.BL.InvoiceBL
{
    public class InvoiceServiceBL: GenericServiceBL<Invoice>, IInvoiceServiceBL
    {
        public InvoiceServiceBL(IUnitOfWork<Invoice> unitOfWork) : base(unitOfWork) { }

        public Invoice InvoiceDetail(Orders orders)
        {
            Invoice invoiceDetail = new Invoice()
            {
                ID = Guid.NewGuid(),
                Total = TotalInvoice(orders.Products),
                Orders = orders,
                OrderDate = DateTime.Now,
                Comments = "Order in progress"
            };
            return invoiceDetail;
        }

        public double TotalInvoice(List<Products> products)
        {
            return products.Sum(item => item.ProductValue);
        }
    }
}
