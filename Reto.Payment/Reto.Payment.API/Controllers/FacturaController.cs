using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reto.Payment.BL.BL.FacturaBL;
using Reto.Payment.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reto.Payment.API.Controllers
{
    [Route("api/Factura")]
    [ApiController]
    public class FacturaController : Controller
    {

        private readonly IFacturaServiceBL _facturaServiceBl;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="facturaServiceBL"></param>
        public FacturaController(IFacturaServiceBL facturaServiceBL)
        {
            _facturaServiceBl = facturaServiceBL;
        }

        [HttpGet]

        /// <summary>
        /// Get Factura
        /// </summary>
        /// <returns>Factura</returns>

        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Factura>> Get () =>
           _facturaServiceBl.Get();

        /// <summary>
        /// Create factura
        /// </summary>
        /// <param name="factura"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] Factura factura)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var facturaCreated = _facturaServiceBl.Create(factura);
                    return CreatedAtAction(nameof(Get), new { id = facturaCreated.Id });
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
