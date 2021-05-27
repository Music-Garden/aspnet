using System;
using MusicGarden.Domain.Abstracts;

namespace MusicGarden.Domain.Models
{
  public class Artist : Entity
  {
    public string name { get; set; }
    public string link { get; set; }
    public string share { get; set; }
    public string picture { get; set; }
    public string picture_small { get; set; }
    public string picture_medium { get; set; }
    public string picture_big { get; set; }
    public string picture_xl { get; set; }
    public int nb_album { get; set; }
    public bool radio { get; set; }
    public string tracklist { get; set; }
  }
}