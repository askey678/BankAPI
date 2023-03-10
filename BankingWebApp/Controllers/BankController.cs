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


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Register()
    {
        Account account = new Account();
        return View(account);
    }


    [HttpPost]
    public IActionResult Register(Account regaccount)
    {
        if(!ModelState.IsValid){
        
        return View();
        }
      
        Console.WriteLine(regaccount.Account_Balance+" "+regaccount.Account_Branch+" "+regaccount.Customer_Name);
        
        return RedirectToAction("Login");
    
    }


    public IActionResult Login()
    {

        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        Console.WriteLine("hello");
        // Console.WriteLine(email , password);
        if(email == "akash.gothria678@gmail.com" && password == "akash")
        {
             Console.WriteLine("hello");
           return RedirectToAction("welcome");
        }


        return View();
    }

    public IActionResult welcome()
    {
        BankManager mgr=new BankManager();
        List<Account> accts=mgr.GetAllAccountsMg();
        this.ViewData["accts"]=accts;
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
