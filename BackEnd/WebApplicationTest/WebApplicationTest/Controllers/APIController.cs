
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.DBProvider;
using WebApplicationTest.model;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {

        private readonly IDBInvoice _dbInvoice;

        public DataController(IDBInvoice dbInvoice)
        {
            _dbInvoice = dbInvoice;
        }

        [HttpGet("/invoices")]
        public IActionResult GetData()
        {
            List<Invoices> result = _dbInvoice.GetData();

            if(result.Count > 0)
            {
                return Ok(new { message = "Data fetched" });
            }
            return BadRequest("No data");
        }
    }
}
