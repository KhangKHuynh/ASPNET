using Microsoft.AspNetCore.Mvc;
using Testing.Data;

namespace Testing.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;
    
    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
   
    // GET
    public IActionResult Index()
    {
        var products = _productRepository.GetAllProducts();
        return View(products);
    }
}