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
            PageList PgL = new PageList();

            Access a = new Access();
            a.AccessPageCreate("Public");
            Console.WriteLine("");
            a.AccessPageCreate("Private");

        }
    }
}
