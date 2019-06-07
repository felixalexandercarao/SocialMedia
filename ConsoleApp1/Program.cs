using System;
using System.Collections.Generic;
using _03.NewBusiness;
using _03.NewRepository;
using Business;
using NewEntity;
using Repository;




namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddObject access = new AddObject();
            Console.Write("Input your privacy level(Private or Public): ");
            string privacy = Console.ReadLine();

            Console.Write("Input your desired name: ");
            string nameInput = Console.ReadLine();

            access.AddPageAndPost(privacy,nameInput);
        }
    }
}
