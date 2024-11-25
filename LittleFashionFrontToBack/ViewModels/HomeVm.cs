using LittleFashionFrontToBack.Model;

namespace LittleFashionFrontToBack.ViewModels;

public class HomeVm
{
    public List<Product> Products { get; set; }
    public List<Category> Categories { get; set; }
    public List<ProductImage> ProductImages { get; set; }
}