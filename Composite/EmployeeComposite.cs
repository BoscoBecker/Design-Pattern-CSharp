namespace Composite;

public class EmployeeComposite(string name) : Employee(name)
{
    private readonly List<Employee> _children = [];
    public override void Add(Employee employee) => this._children.Add(employee);
    public override void Remove(Employee employee) => this._children.Remove(employee);
    public override Employee GetChild(int index) => this._children[index];
    public override string Operation() =>  this._children.Aggregate($"Employee: {this.Name}\n", 
         (current, child) => current + child.Operation());
    
}