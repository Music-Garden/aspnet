using System;
using System.Collections.Generic;
using MusicGarden.Domain.Abstracts;

namespace MusicGarden.Domain.Models
{
  public class Album : Entity
  {
    public string title { get; set; }
    public string upc { get; set; }
    public string link { get; set; }
    public string share { get; set; }
    public string cover { get; set; }
    public string cover_small { get; set; }
    public string cover_medium { get; set; }
    public string cover_big { get; set; }
    public string cover_xl { get; set; }
    public string md5_image { get; set; }
    public int genre_id { get; set; }
    public List<Genre> genres { get; set; }
    public string label { get; set; }
    public int nb_tracks { get; set; }
    public int duration { get; set; }
    public int fans { get; set; }
    public int rating { get; set; }
    public DateTime release_date { get; set; }
    public string record_type { get; set; }
    public bool available { get; set; }
    public object alternative { get; set; }
    public string tracklist { get; set; }
    public bool explicit_lyrics { get; set; }
    public int explicit_content_cover { get; set; }
    public int explicit_content_lyrics { get; set; }
    public List<string> contributors { get; set; }
    public Artist artist { get; set; }
    public List<Track> tracks { get; set; }
  }
}