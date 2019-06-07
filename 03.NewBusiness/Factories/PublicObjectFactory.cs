using NewEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.NewBusiness
{
    class PublicObjectFactory : IObjectFactory
    {
        public BasePage createPage()
        {
            return new PublicPage()
            {
                PageName = string.Empty,
                ViewablePage = true,
                PageDateCreated = DateTime.Now,
            };
        }

        public BasePost createPost()
        {
            return new PublicPost()
            {
                Body = string.Empty,
                ViewablePost = true,
                PostDateCreated = DateTime.Now,
            };
        }
    }
}
