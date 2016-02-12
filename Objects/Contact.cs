using System;
using System.Collections.Generic;

namespace ContactList
{

  public class Contact
  {
    private string _name { get; set; }
    private string _phoneNumber { get; set; }
    private string _address { get; set; }
    private static List<Contact> _contacts = new List<Contact> {};

    public Contact(string new_name, string new_phoneNumber, string new_address)
    {
      _name = new_name;
      _phoneNumber = new_phoneNumber;
      _address = new_address;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }

    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }

    public static List<Contact> GetAll()
    {
      return _contacts;
    }

    public void Save()
    {
      _contacts.Add(this);
    }

    //this method is not currently working, have to find out why. here or in HomeModule.cs?
    public static void DeleteAll()
    {
      _contacts.Clear();
    }
  }
}
