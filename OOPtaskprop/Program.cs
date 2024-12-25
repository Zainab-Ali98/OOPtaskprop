// See https://aka.ms/new-console-template for more information

using OOPtaskprop.Models;

Users user = new Users();

Console.WriteLine("enter your name");
user.UserName = Console.ReadLine();
user.GetUserName();

Console.WriteLine("enter salary");
user.salary =Convert.ToDouble(Console.ReadLine());