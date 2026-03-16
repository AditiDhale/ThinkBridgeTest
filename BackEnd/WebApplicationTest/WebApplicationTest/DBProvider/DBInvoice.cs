using WebApplicationTest.model;
using AutoMapper;
using static BuggyApp.Controllers.InvoiceController;

namespace WebApplicationTest.DBProvider
{

    public class DBInvoice: IDBInvoice
    {
        private readonly IConfiguration _configuration;
        private readonly InvoiceContext _context;
        private readonly IMapper _mapper;
        public DBInvoice(IConfiguration config, InvoiceContext context, IMapper mapper ) { 
            _configuration = config;
            _context = context;
            _mapper = mapper;
        }

        public List<Item> GetInvoice(int id)
        {
            var invoice = _context.InvoiceItems.Find(id);
            return _mapper.Map<List<Item>>(invoice);
        }

        public List<Invoices> GetData() { 
            return _context.Invoices.ToList();
        }
    }
}
