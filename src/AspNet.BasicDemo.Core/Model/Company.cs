namespace AspNet.BasicDemo.Core.Model;

public class Company : BaseEntity
{
    public string Name { get; set; }
    public string Website { get; set; }
    public virtual List<Customer> Customers { get; set; } = new();
}