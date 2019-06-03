using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
    public class DeletePost
    {
        public void deletePost(string DeleteID, List<Post> postList)
        {
            postList.RemoveAll(s => DeleteID == s.ID);
        }
    }
}
