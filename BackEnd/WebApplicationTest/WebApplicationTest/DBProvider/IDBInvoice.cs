using WebApplicationTest.model;
using static BuggyApp.Controllers.InvoiceController;

namespace WebApplicationTest.DBProvider
{
    public interface IDBInvoice
    {
        List<Item> GetInvoice(int id);

        List<Invoices> GetData();
    }
}
