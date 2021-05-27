using System;
using MusicGarden.Domain.Abstracts;

namespace MusicGarden.Domain.Models
{
  public class Episode : Entity
  {
    public string title { get; set; }
    public string description { get; set; }
    public bool available { get; set; }
    public DateTime release_date { get; set; }
    public int duration { get; set; }
    public string link { get; set; }
    public string share { get; set; }
    public string picture { get; set; }
    public string picture_small { get; set; }
    public string picture_medium { get; set; }
    public string picture_big { get; set; }
    public string picture_xl { get; set; }
    public Podcast podcast { get; set; }
  }
}