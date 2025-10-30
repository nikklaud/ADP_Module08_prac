namespace Module08_prac.Decorator;

public class SortingDecorator: ReportDecorator
{
    public SortingDecorator(IReport report) : base(report)
    {
        
    }

    public override string Generate()
    {
        var report = base.Generate();
        return $"Sorted by some value: {report}";
    }
}