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

      return View("index");

    }
    public IActionResult Song(SongModel Searched)
    {
      if (Searched.search == null)
        return View("song", Searched);
      else if (ModelState.IsValid)
      {
        var response = client.GetAsync($"{_configuration["Services:webapi"]}/music/search?name={Searched.search}").GetAwaiter().GetResult();
        if (response.IsSuccessStatusCode)
        {
          List<string> searchResults = JsonConvert.DeserializeObject<List<string>>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
          List<string> searchRes = new List<string>();
          foreach (var item in searchResults)
          {
            searchRes.Add(item.Substring(23));
          }
          ViewBag.SearchResults = searchRes;
          return View("songresults");
        }
      }


      return View("index"); //to see if errors are thrown 
    }
    public IActionResult Playlist()
    {
      return View("playlist");
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
