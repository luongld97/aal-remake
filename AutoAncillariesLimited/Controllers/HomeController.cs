using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AutoAncillariesLimited.Models;
using Data;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace AutoAncillariesLimited.Controllers
{
  public class HomeController : Controller
  {
    private readonly AALDbContext _dbContext;
    private readonly IUserRepository _userRepository;
    private readonly ICategoryRepository _userRoleRepository;

    public HomeController(AALDbContext dbContext, IUserRepository userRepository, ICategoryRepository userRoleRepository)
    {
      _dbContext = dbContext;
      _userRepository = userRepository;
      _userRoleRepository = userRoleRepository;
    }

    public IActionResult Index()
    {
      var users = _dbContext.Users.Where(u => u.Active).ToList();
      return View();
    }

    public IActionResult About()
    {
      ViewData["Message"] = "Your application description page.";

      return View();
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Your contact page.";

      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
  }
}