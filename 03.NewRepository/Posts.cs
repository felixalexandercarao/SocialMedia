using NewEntity;
using System;
using System.Collections.Generic;

namespace _03.NewRepository
{
    public class PostList
    {

        public List<BasePost> postList { get; set; }
        public PostList()
        {
            this.postList = new List<BasePost>()
            {
                new PublicPost()
                {
                Body = "Sample Public Post",
                ViewablePost = true,
                PostDateCreated =DateTime.Now,
                },
                new PrivatePost()
                {
                Body = "Sample Private Post",
                ViewablePost = false,
                PostDateCreated =DateTime.Now,
                }
            };
        }
        public List<BasePost> GetPostList()
        {
            return this.postList;
        }

        public void RepoAddPost(BasePost p,string postBody)
        {
            p.Body = postBody;
            this.postList.Add(p);
        }
        public void DeletePost(string deleteBody)
        {
            this.postList.RemoveAll(s => s.Body == deleteBody);
        }
    }
}
