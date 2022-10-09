using Reto.Payment.BL.Interfaces;
using Reto.Payment.Models;
using System.Collections.Generic;

namespace Reto.Payment.BL.InvoiceBL
{
    public interface IInvoiceServiceBL: IGenericServiceBL<Invoice>
    {
        double TotalInvoice(List<Products> products);

        Invoice InvoiceDetail(Orders orders);
    }
}
