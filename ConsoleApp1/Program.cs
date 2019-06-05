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
            Console.WriteLine("Original List");/*I print the original list*/
            foreach (BasePage page in PgL.GetPageList())
            {
                Console.WriteLine("Name: {0} | Public: {1}", page.PageName, page.ViewablePage);
            }
            Console.WriteLine("");

            a.AccessPageCreate("Public Page"); /*the method for adding a new public page and i print list while still in the method*/

            Console.WriteLine("");
            Console.WriteLine("I view the list after method is done");/*I print list again*/
            foreach (BasePage page in PgL.GetPageList())
            {
                Console.WriteLine("Name: {0} | Public: {1}", page.PageName, page.ViewablePage);
            }

        }
    }
}
