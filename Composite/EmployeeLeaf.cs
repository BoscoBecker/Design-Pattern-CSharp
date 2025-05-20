namespace Composite;

public class EmployeeLeaf(string name) : Employee(name)
{
    public override string Operation() => "Leaf" + this.Name;
}