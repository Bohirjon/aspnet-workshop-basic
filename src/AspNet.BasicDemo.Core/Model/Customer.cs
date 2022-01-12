namespace AspNet.BasicDemo.Core.Model;

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int? CompanyId { get; set; }
    public virtual Company Company { get; set; }
}