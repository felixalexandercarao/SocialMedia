using System;
using System.Collections.Generic;
using Business;
using Entity;
using Repository;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            PostActions c = new PostActions();
            c.NewPost("lebron");
            c.NewPost("lebggron");


            foreach (Post PA in c.viewPost())
            {
                Console.WriteLine("Name: {0} || Age: {1} || ID: {2} || Date Created: {3}", PA.PostBody, PA.PostType, PA.ID, PA.DateCreated);
            }
            Console.ReadLine();
        }
    }
}
