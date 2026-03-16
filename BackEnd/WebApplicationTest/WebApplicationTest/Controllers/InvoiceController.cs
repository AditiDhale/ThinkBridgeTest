
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationTest.DBProvider;
using WebApplicationTest.model;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly IDBInvoice _dbInvoice;

        public InvoiceController(IDBInvoice dbInvoice)
        {
            _dbInvoice = dbInvoice;
        }


        [HttpGet("{id}")]
        public IActionResult GetInvoice([FromRoute] int id)
        {
            List<Item> items = _dbInvoice.GetInvoice(id);
            if (items.Count == 0)
            {
                return Ok(new { items });
            }
            return NotFound("No invoice found");
        }

        [HttpGet]
        public IActionResult GetInvoices()
        {
            List<Invoices> items = _dbInvoice.GetData();
            if (items.Count == 0)
            {
                return Ok(new { items });
            }
            return NotFound("No invoice found");
        }

        public class Item
        {
            public string name { get; set; }
            public double price { get; set; }
        }
    }
}
