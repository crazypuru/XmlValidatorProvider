
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace XmlValidatorProvider.Models
{
  public class Event
  {
    public string Name
    { get; set; }

    public string Place
    { get; set; }

    public DateTime Date
    { get; set; }
  }
}