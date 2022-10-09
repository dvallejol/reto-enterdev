using Reto.Payment.BL.Generic;
using Reto.Payment.DAL.Interfaces;
using Reto.Payment.DAL.Migrations;
using Reto.Payment.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reto.Payment.BL.BL.FacturaBL
{
    public class FacturaServiceBL : GenericServiceBL<Factura>, IFacturaServiceBL
    {
        public FacturaServiceBL(IUnitOfWork<Factura> unitOfWork) : base(unitOfWork)
        {
        }
    }
}


