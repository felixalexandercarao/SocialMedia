using System;
using System.Collections.Generic;
using System.Text;
using _03.NewRepository;
using NewEntity;

namespace _03.NewBusiness
{
    public class AddObject
    {
        PageList pageList = new PageList();
        PostList postList = new PostList();
        PublicObjectFactory OFPublic = new PublicObjectFactory();
        PrivateObjectFactory OFPrivate = new PrivateObjectFactory();
        public void AddPageAndPost(string privacy, string nameInput,string postInput)
        {
            if (privacy == "Public")
            {
                BasePage newPage = OFPublic.createPage();
                newPage.PageName = nameInput;
                BasePost newPost = OFPublic.createPost();
                newPost.Body = postInput;
                pageList.RepoAddPage(newPage);
                postList.RepoAddPost(newPost);
            }
            if (privacy == "Private")
            {
                BasePage newPage = OFPrivate.createPage();
                newPage.PageName = nameInput;
                BasePost newPost = OFPrivate.createPost();
                newPost.Body = postInput;
                pageList.RepoAddPage(newPage);
                postList.RepoAddPost(newPost);
            }
            foreach (BasePage pg in pageList.GetPageList())
            {
                Console.WriteLine("Name: {0} | Public: {1}", pg.PageName, pg.ViewablePage);
            }
            Console.WriteLine("");
            foreach (BasePost p in postList.GetPostList())
            {
                Console.WriteLine("Body: {0} | Public: {1}", p.Body, p.ViewablePost);
            }
        }
    }
}
