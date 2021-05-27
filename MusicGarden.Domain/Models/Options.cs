using System;
using MusicGarden.Domain.Abstracts;

namespace MusicGarden.Domain.Models
{
  public class Options
  {
    public bool streaming { get; set; }
    public int streaming_duration { get; set; }
    public bool offline { get; set; }
    public bool hq { get; set; }
    public bool ads_display { get; set; }
    public bool ads_audio { get; set; }
    public bool too_many_devices { get; set; }
    public bool can_subscribe { get; set; }
    public int radio_skips { get; set; }
    public bool lossless { get; set; }
    public bool preview { get; set; }
    public bool radio { get; set; }
  }
}