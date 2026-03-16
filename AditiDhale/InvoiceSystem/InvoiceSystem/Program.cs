// See https://aka.ms/new-console-template for more information
using UsageBillingApp.Services;

Console.WriteLine("Hello, World!");

if (args.Length == 0)
{
    Console.WriteLine("Please provide a filename as a command-line argument.");
    return;
}

string filePath = args[0];// "usage-data.json";

var loader = new InputLoader();
var calculator = new InvoiceCalculator();
var printer = new InvoicePrinter();

var records = loader.LoadValidRecords(filePath);

foreach (var record in records)
{
    var result = calculator.Calculate(record);

    printer.Print(
        record,
        result.apiCost,
        result.storageCost,
        result.computeCost,
        result.total
    );
}