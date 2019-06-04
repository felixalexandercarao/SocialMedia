using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class PostActions
    {
        Repository.PostList PL = new Repository.PostList();
        public void NewPost(string PostInput)
        {
            Post newPost = new Post
            {
                PostBody = PostInput,
                PostType = "Text",
                ID = "P-001",
                DateCreated = DateTime.Now,
                Privacy = "Public"
            };
            PL.AddPost(newPost);
        }
            public List<Post> viewPost()
            {
                return PL.GetPostAccountList();
            }
            public void deletePost(string DeleteID)
            {
            PL.DeletePost(DeleteID);
            }
    }
}
