using System;
using System.Collections.Generic;

namespace ContactList
{

  public class Contact
  {
    private string name { get; set; }
    private string phoneNumber { get; set; }
    private string address { get; set; }
    private int id { get; set; }

    private static List<Contact> contacts = new List<Contact> {};

    public Contact(string new_name, string new_phoneNumber, string new_address)
    {
      name = new_name;
      phoneNumber = new_phoneNumber;
      address = new_address;
      contacts.Add(this);
      id = contacts.Count;
    }

    public string GetName()
    {
      return name;
    }

    public string GetPhoneNumber()
    {
      return phoneNumber;
    }

    public string GetAddress()
    {
      return address;
    }

    public static List<Contact> All()
    {
      return contacts;
    }

    public static Contact Find(int id)
    {
      return contacts[id-1];
    }

    //this method is not currently working, have to find out why. here or in HomeModule.cs?
    public static void DeleteAll()
    {
      contacts.Clear();
    }
  }
}
