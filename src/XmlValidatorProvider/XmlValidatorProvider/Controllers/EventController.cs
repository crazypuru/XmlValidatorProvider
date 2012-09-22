using XmlValidatorProvider.Models;
using System.Web.Mvc;

namespace XmlValidatorProvider.Controllers
{
  public class EventController : Controller
  {
    public ViewResult Index()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Index(Event evt)
    {
      if (ModelState.IsValid)
      {
        //TODO: save event

        return View("Thanks", evt);
      }

      return View();
    }
  }
}
