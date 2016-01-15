using Nancy;
using Nancy.ViewEngines.Razor;
using System.Collections.Generic;

namespace ContactList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      //routes go here
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/contacts"] = _ => {
        var AllContacts = Contact.All();
        return View["contacts.cshtml", AllContacts];
      };
    }
  }
}
