using LittleFashionFrontToBack.DAL;
using LittleFashionFrontToBack.Model;
using LittleFashionFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LittleFashionFrontToBack.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _appDbContext;

    public HomeController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public IActionResult Index()
    {
        List<Product> products = _appDbContext.Products.Include(x => x.ProductImages).ToList();

        HomeVm vm = new HomeVm()
        {
            Products = products
        };

        return View(vm);
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var product = await _appDbContext.Products
            .Include(x => x.Category)
            .Include(x => x.ProductImages)
            .FirstOrDefaultAsync(x => x.Id == id);
        
        return View(product);
    }
}