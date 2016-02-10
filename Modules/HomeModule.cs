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
        var allContacts = Contact.All();
        return View["contacts.cshtml", allContacts];
      };
      Get["/contacts/new"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contacts"] = _ => {
        var name = Request.Form["contact-name"];
        var phoneNumber = Request.Form["contact-phone-number"];
        var address = Request.Form["contact-address"];
        var newContact = new Contact(name, phoneNumber, address);
        newContact.Save();
        return View["contact_created.cshtml", newContact];
      };
      Post["/contacts_cleared"] = _ => {
        Contact.DeleteAll();
        return View["contacts_cleared.cshtml"];
      };
    }
  }
}
