using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
    public class ViewPost
{
        public void viewPost(List<Post> postList)
        {
            foreach (Post PA in postList)
            {
                Console.WriteLine("Type: {0} || Body: {1} || ID: {2} || Date Created: {3}", PA.PostType, PA.PostBody, PA.ID, PA.DateCreated);
            }
        }
    }
}
