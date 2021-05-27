using System;
using System.Collections.Generic;
using MusicGarden.Domain.Abstracts;

namespace MusicGarden.Domain.Models
{
  public class User : Entity
  {
    public string name { get; set; }
    public string lastname { get; set; }
    public string firstname { get; set; }
    public string email { get; set; }
    public int status { get; set; }
    public DateTime birthday { get; set; }
    public DateTime inscription_date { get; set; }
    public string gender { get; set; }
    public string link { get; set; }
    public string picture { get; set; }
    public string picture_small { get; set; }
    public string picture_medium { get; set; }
    public string picture_big { get; set; }
    public string picture_xl { get; set; }
    public string country { get; set; }
    public string lang { get; set; }
    public bool is_kid { get; set; }
    public string explicit_content_level { get; set; }
    public Array explicit_content_levels_available { get; set; }
    public string tracklist { get; set; }
  }
}