using System;
using Business;
using Repository;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //PersonalAccountList a = new PersonalAccountList();
            //ViewPersonalAccount c = new ViewPersonalAccount();
            PostList a = new PostList();
            ViewPost c = new ViewPost();
            AddPost d = new AddPost();
            DeletePost e = new DeletePost();
            d.NewPost("lebron>kobe",a.postList);
            e.deletePost("P-002", a.postList);
            c.viewPost(a.postList);
            Console.ReadLine();
        }
    }
}
