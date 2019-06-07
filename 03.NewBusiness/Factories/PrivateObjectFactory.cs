using System;
using NewEntity;

namespace _03.NewBusiness
{
    class PrivateObjectFactory : IObjectFactory
    {
        public BasePage createPage()
        {
            return new PrivatePage()
            {
                PageName =string.Empty,
                ViewablePage = false,
                PageDateCreated=DateTime.Now,
            };
        }

        public BasePost createPost()
        {
            return new PrivatePost()
            {
                Body=string.Empty,
                PostDateCreated=DateTime.Now,
                ViewablePost=false,
            };
        }
    }
}
