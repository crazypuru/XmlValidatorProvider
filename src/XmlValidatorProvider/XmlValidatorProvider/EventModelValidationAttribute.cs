using System.ComponentModel.DataAnnotations;
using XmlValidatorProvider.Models;

namespace XmlValidatorProvider
{
  public class EventModelValidationAttribute: ValidationAttribute
  {
    public override bool IsValid(object value)
    {
      var evt = value as Event;

      if (evt.Place == "Bangalore" && evt.Date.Year == 2014)
        return false;

      return true;
    }
  }
}

