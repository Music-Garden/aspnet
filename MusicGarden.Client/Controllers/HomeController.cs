using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using MusicGarden.Client.Models;

namespace MusicGarden.Client.Controllers
{

  [Route("[controller]/[action]")]
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
      var response = client.GetAsync($"{_configuration["Services:webapi"]}/Music").GetAwaiter().GetResult();
      //string result = null;


      if (response.IsSuccessStatusCode)
      {
        var result = JsonConvert.DeserializeObject<JsonObjectAttribute>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        ViewBag.Music = result;
        return View("index");
      }

      return null;

    }
    public IActionResult Song(SongModel Searched)
    {
      if (Searched.search == null)
        return View("song", Searched);
      else if (ModelState.IsValid)
      {
        var response = client.GetAsync($"{_configuration["Services:webapi"]}/music/search?q={Searched.search}").GetAwaiter().GetResult();
        if (response.IsSuccessStatusCode)
        {
          var searchResults = JsonConvert.DeserializeObject<JsonObjectAttribute>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
          return View("songresults", searchResults);
        }
      }


      return View("index"); //to see if errors are thrown 
    }
    public IActionResult Search(SongModel search)
    {
      if (search == null)
        return View("index");
      else if (ModelState.IsValid)
      {
        var response = client.GetAsync($"{_configuration["Services:webapi"]}/music/{search}").GetAwaiter().GetResult();
        if (response.IsSuccessStatusCode)
        {
          var searchResults = JsonConvert.DeserializeObject<JsonObjectAttribute>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
          return View("songresults", searchResults);
        }
      }
      return View("index", new ErrorViewModel());
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
