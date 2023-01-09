using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BankingWebApp.Models;
using BLL;
using BOL;

namespace BankingWebApp.Controllers;

public class BankController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public BankController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Account()
    {
        BankManager manager = new BankManager();
        List<Account> accounts=new List<Account>();
        accounts=manager.GetAllAccountsMg();
        this.ViewData["accounts"]=accounts;
        return View();
    }

  

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
