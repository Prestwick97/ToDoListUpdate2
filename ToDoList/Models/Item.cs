using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ToDoList.Models

{
  public class Item
  {
    public string Description { get; set; }
    public int Id { get; }

    public Item(string description)
    {
      Description = description;
    }
    // public static List<Item> GetAll()
    // {
    //     if (_instances.Count == 0)
    //     {
    //         Console.WriteLine("No Items in List");
    //     }
    //     return _instances;
    // // }
    // public static void ClearAll()
    // {
    //     _instances.Clear();
    // }
    public static Item Find(int searchId)
    {
      Item placeholderItem = new Item("placeholder item");
      return placeholderItem;
    }

  }
}