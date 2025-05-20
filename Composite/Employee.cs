namespace Composite;

public abstract class Employee(string name)
{
    public string Name { get; set; } = name;
    public abstract string Operation();
    public virtual void Add(Employee employee) => throw new NotImplementedException();
    
    public virtual void Remove(Employee employee) => throw new NotImplementedException();
    
    public virtual Employee GetChild(int index) => throw new NotImplementedException();

}

