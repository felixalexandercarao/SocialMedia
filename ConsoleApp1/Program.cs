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
            Access a = new Access();
            PageList PgL = new PageList();
            Console.Write("Input your privacy level(Private or Public): ");
            string privacy = Console.ReadLine();
            Console.WriteLine("");
            a.AccessPageAndPostCreate(privacy); 
        }
    }
}
