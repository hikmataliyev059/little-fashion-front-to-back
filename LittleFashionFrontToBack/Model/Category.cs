using LittleFashionFrontToBack.Model.Base;

namespace LittleFashionFrontToBack.Model;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }
}