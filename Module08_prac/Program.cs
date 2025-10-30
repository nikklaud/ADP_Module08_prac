using Module08_prac.Decorator;

namespace Module08_prac;

internal class Program
{
    public static void Main(string[] args)
    {
        IReport report = new SalesReport();
        report = new SortingDecorator(report);
        report = new SortingDecorator(report);
        
        
    }
}