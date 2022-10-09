using System;
using System.Net.Mime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reto.Payment.BL.InvoiceBL;
using Reto.Payment.Models;


namespace Reto.Payment.API.Controllers
{

    [Route("api/payment")]
    [ApiController]
    public class PaymentController : Controller
    {

        private readonly IInvoiceServiceBL _invoiceServiceBL;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="invoiceServiceBL"></param>
        public PaymentController(IInvoiceServiceBL invoiceServiceBL)
        {
            _invoiceServiceBL = invoiceServiceBL;
        }

        /// <summary>
        /// Create Order
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Invoice> CreateOrder([FromBody] Orders orders)
        {
            try
            {
                if (ModelState.IsValid)
                {                    
                    return _invoiceServiceBL.InvoiceDetail(orders);
                }
                return BadRequest();

            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
