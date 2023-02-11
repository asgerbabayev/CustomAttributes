using ConsoleApp1.Extensions;
using ConsoleApp1.Models;

User user = new User();

user.Email = "salam@gmail.com";

if (ModelState.IsValid(user))
    Console.WriteLine("email format is correct");
else
    Console.WriteLine("email format is incorrect");


