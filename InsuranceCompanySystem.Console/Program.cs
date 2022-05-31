using InsuranceCompanySystem.App;

Console.WriteLine("Insurance System Starting...");

var engine = new InsuranceEngine();
engine.Rate();

if (engine.Rating > 0)
{
    Console.WriteLine($"Rating: {engine.Rating}");
}
else
{
    Console.WriteLine("No rating produced.");
}