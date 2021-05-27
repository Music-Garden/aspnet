using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Medialab.Client.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Medialab.Client.Controllers
{
  public class HomeController : Controller
  {

    private static readonly HttpClient client = new HttpClient();
    private IConfiguration _configuration;
    public HomeController(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    public IActionResult Index()
    {
      var response = client.GetAsync($"{_configuration["Services:webapi"]}/Music/search").GetAwaiter().GetResult();
      string result = null;


      if (response.IsSuccessStatusCode)
      {
        result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

        var path = result.Substring(22);
        ViewBag.Music = path;

        return View("index");
      }

      return null;

    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
