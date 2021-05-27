using System;
using System.Collections.Generic;
using MusicGarden.Domain.Abstracts;

namespace MusicGarden.Domain.Models
{
  public class Track : Entity
  {
    public bool readable { get; set; }
    public string title { get; set; }
    public string title_short { get; set; }
    public string title_version { get; set; }
    public bool unseen { get; set; }
    public string isrc { get; set; }
    public string link { get; set; }
    public string share { get; set; }
    public int track_position { get; set; }
    public int disk_number { get; set; }
    public int rank { get; set; }
    public DateTime release_data { get; set; }
    public bool explicit_lyrics { get; set; }
    public int explicit_content_lyrics { get; set; }
    public int explicit_content_cover { get; set; }
    public string preview { get; set; }
    public float bpm { get; set; }
    public float gain { get; set; }
    public List<string> available_countries { get; set; }
    public Track alternative { get; set; }
    public List<string> contributors { get; set; }
    public string md5_image { get; set; }
    public Artist artist { get; set; }
    public Album album { get; set; }
  }
}