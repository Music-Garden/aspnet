using System.Collections.Generic;
using MusicGarden.Domain.Abstracts;

namespace MusicGarden.Domain.Models
{
  public class Playlist : Entity
  {
    public string title { get; set; }
    public string description { get; set; }
    public int duration { get; set; }
    public bool Public { get; set; }
    public bool is_loved_track { get; set; }
    public bool collaborative { get; set; }
    public int rating { get; set; }
    public int nb_tracks { get; set; }
    public int unseen_track_count { get; set; }
    public int fans { get; set; }
    public string share { get; set; }
    public string link { get; set; }
    public string picture { get; set; }
    public string picture_small { get; set; }
    public string picture_medium { get; set; }
    public string picture_big { get; set; }
    public string picture_xl { get; set; }
    public string checksum { get; set; }
    public User creator { get; set; }
    public List<Track> tracks { get; set; }
  }
}