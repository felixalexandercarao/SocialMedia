using System;
using System.Collections.Generic;
using System.Text;
using _03.NewRepository;
using NewEntity;

namespace _03.NewBusiness
{
    class AddObject
    {
        PageList PgL = new PageList();
        PostList PstL = new PostList();
        PublicObjectFactory OFPublic = new PublicObjectFactory();
        PrivateObjectFactory OFPrivate = new PrivateObjectFactory();
        public void AddPageAndPost(string privacy)
        {
            Console.Write("Input your desired name: ");
            string nameInput = Console.ReadLine();
            Console.Write("Input your first post: ");
            string postInput = Console.ReadLine();
            if (privacy == "Public")
            {  
                PgL.RepoAddPage(OFPublic.createPage(),nameInput);
                PstL.RepoAddPost(OFPublic.createPost(),postInput);
            }
            if (privacy == "Private")
            {
                PgL.RepoAddPage(OFPrivate.createPage(),nameInput);
                PstL.RepoAddPost(OFPrivate.createPost(),postInput);
            }


            foreach (BasePage pg in PgL.GetPageList())
            {
                Console.WriteLine("Name: {0} | Public: {1}", pg.PageName, pg.ViewablePage);
            }
            Console.WriteLine("");
            foreach (BasePost p in PstL.GetPostList())
            {
                Console.WriteLine("Body: {0} | Public: {1}", p.Body, p.ViewablePost);
            }
        }
    }
}
