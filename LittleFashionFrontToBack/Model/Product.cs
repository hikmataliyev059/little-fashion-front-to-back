using LittleFashionFrontToBack.Model.Base;

namespace LittleFashionFrontToBack.Model;

public class Product : BaseEntity
{
    public string Title { get; set; }
    public string SubTitle { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<ProductImage> ProductImages { get; set; } 
}