using System;
using System.Collections.Generic;
using System.Text;
using _03.NewRepository;
using NewEntity;

namespace _03.NewBusiness
{
    class AddObject
    {
        PageList PL = new PageList();
        PostList PstL = new PostList();
        public void AddPage(ObjectFactory OF, string pageName)
        {
            PL.RepoAddPage(OF.createPage(pageName, DateTime.Now));
            Console.WriteLine("In the Method:");
            foreach (BasePage pg in PL.GetPageList())
            {
                Console.WriteLine("Name: {0} | Public: {1}", pg.PageName, pg.ViewablePage);
            }
        }
        public void AddPost(ObjectFactory OF, string postName)
        {
            PstL.RepoAddPost(OF.createPost(postName, DateTime.Now));
            foreach (BasePost pst in PstL.GetPostList())
            {
                Console.WriteLine("Body: {0} | Public: {1}", pst.Body, pst.ViewablePost);
            }
        }
    }
}
