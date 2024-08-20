using Microsoft.AspNetCore.Mvc;
using SistemaPromocaoMVC.Data;
using SistemaPromocaoMVC.Models;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var viewModel = new SistemaViewModel
        {
            Promotores = _context.Promotores.ToList(),
            Escritores = _context.Escritores.ToList(),
            Bodybuilders = _context.Bodybuilders.ToList(),
            Vloggers = _context.Vloggers.ToList()
        };

        return View(viewModel);
    }
}
