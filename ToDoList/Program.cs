using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main(string [] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();

      Console.WriteLine("Welcome to the To Do List");
      Console.ReadLine();
      Welcome();
    }
    public static void Welcome()
    {
      Console.WriteLine("Would you like to add an item to your list or view your list (Add/View) OR EXIT");
      string userView = Console.ReadLine();
      if (userView == "Add" || userView == "add")
      {
        AddToList();
      }
      else if (userView == "View" || userView == "view")
      {
        ViewList();
      }
      else if (userView == "EXIT")
      {
        Exit();
      } 
      else
      {
        Console.WriteLine();
        Console.WriteLine("Please Re-Enter your selection");
        Welcome();
      }
    }
    public static void AddToList()
    {
      Console.WriteLine("Please Enter Description for New To-Do List Item");
      string userDescription = Console.ReadLine();
      Item newItem = new Item(userDescription);
      Console.WriteLine();
      Console.WriteLine("\'" + userDescription + "\'" + " has been added to your To-Do List!");
      Welcome();
    }
    public static void ViewList()
    {
      Console.WriteLine("TO-DO LIST:");
      Console.WriteLine();
      List<Item> result = Item.GetAll();
      int itemNumber = 0;
      foreach (Item thisItem in result)
      {
      itemNumber ++;
      Console.WriteLine(itemNumber + ") " + thisItem.Description);
      }
      Console.WriteLine();
      Welcome();
    }
    public static void Exit()
    {
      Console.WriteLine("GOODBYE!");
    }
    
  }
}