namespace Module08_prac.Decorator;

public class SalesReport: IReport
{
    public string Generate()
    {
        return "Sales Report";
    }
}