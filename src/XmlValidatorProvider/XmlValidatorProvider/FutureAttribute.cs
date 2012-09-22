
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace XmlValidatorProvider
{
  public class FutureAttribute: ValidationAttribute, IClientValidatable
  {
    public override bool IsValid(object value)
    {
      return value != null && (DateTime)value > DateTime.Now;
    }

    public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
    {
      yield return new ModelClientValidationRule
      {
        ErrorMessage = ErrorMessage,
        ValidationType = "futuredate"
      };
    }
  }
}