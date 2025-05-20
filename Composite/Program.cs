namespace Composite;

internal static class Program
{
    private static void Main()
    {
        var ceo = new EmployeeComposite("John");
        var headSales = new EmployeeComposite("Robert");
        var headMarketing = new EmployeeComposite("Michel");
        
        var clerk1 = new EmployeeLeaf("Laura");
        var clerk2 = new EmployeeLeaf("Bob");
        
        var salesExecutive1 = new EmployeeLeaf("Richard");
        var salesExecutive2 = new EmployeeLeaf("Rob");
        
        ceo.Add(headSales);
        ceo.Add(headMarketing);
        
        headSales.Add(salesExecutive1);
        headSales.Add(salesExecutive2);
        
        headMarketing.Add(clerk1);
        headMarketing.Add(clerk2);
        
        Console.WriteLine(ceo.Operation());
        Console.WriteLine(headSales.Operation());
        Console.WriteLine(headMarketing.Operation());
    }
}