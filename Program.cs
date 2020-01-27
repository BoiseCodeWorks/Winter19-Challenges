using System;
using System.Collections.Generic;
using morning_challenge.Models;

namespace morning_challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            User mark = new User("Mark", "I<3Code");
            User jake = new User("Jake", "MarkIsSoCool");
            User darryl = new User("D$", "IHeartTheOutside");

            Dictionary<string, User> Users = new Dictionary<string, User>(){
                {mark.UserName.ToLower(), mark},
                {jake.UserName.ToLower(), jake},
                {darryl.UserName.ToLower(), darryl}
            };

            // Users.Add(mark.UserName.ToLower(), mark);
            // Users.Add(jake.UserName.ToLower(), jake);
            // Users.Add(darryl.UserName.ToLower(), darryl);
            bool running = true;
            Console.Clear();
            while (running)
            {
                Console.Write("UserName: ");
                string name = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Password: ");
                string pass = Console.ReadLine();

                if (Users.ContainsKey(name.ToLower()) && Users[name.ToLower()].ValidatePassword(pass))
                {
                    Console.WriteLine("Successfully logged in");
                    running = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid username or password");
                }
            }
        }
    }
}
