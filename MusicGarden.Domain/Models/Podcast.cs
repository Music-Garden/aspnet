using System.Collections.Generic;
using MusicGarden.Domain.Abstracts;

namespace MusicGarden.Domain.Models
{
  public class Podcast : Entity
  {
    public string title { get; set; }
    public string description { get; set; }
    public bool available { get; set; }
    public int rating { get; set; }
    public int fans { get; set; }
    public string share { get; set; }
    public string link { get; set; }
    public string picture { get; set; }
    public string picture_small { get; set; }
    public string picture_medium { get; set; }
    public string picture_big { get; set; }
    public string picture_xl { get; set; }
  }
}