using System.Collections.Generic;
using MusicGarden.Domain.Abstracts;

namespace MusicGarden.Domain.Models
{
  public class Radio : Entity
  {
    public string title { get; set; }
    public string description { get; set; }
    public string share { get; set; }
    public string link { get; set; }
    public string picture { get; set; }
    public string picture_small { get; set; }
    public string picture_medium { get; set; }
    public string picture_big { get; set; }
    public string picture_xl { get; set; }
    public string tracklist { get; set; }
    public string md5_image { get; set; }

  }
}