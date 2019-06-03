using System;
using System.Collections.Generic;
using Entity;
using Repository;

namespace Business
{
    public class AddPost
    {
        public void NewPost(string PostInput, List<Post> postList)
        {
            Post newPost = new Post
            {
                PostBody = PostInput,
                PostType = "Text",
                ID ="P-001",
                DateCreated = DateTime.Now ,
                Privacy ="Public"
            };
            postList.Add(newPost);
        }
    }
}
