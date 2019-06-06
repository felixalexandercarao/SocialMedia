using System;
using NewEntity;

namespace _03.NewBusiness
{
    class PrivateObjectFactory : IObjectFactory
    {
        public BasePage createPage(/*string pageNameInput, DateTime pageDateCreated*/)
        {
            return new PrivatePage()
            {
                PageName =string.Empty,
                ViewablePage = false,
                PageDateCreated=DateTime.Now
            };
        }

        public BasePost createPost(/*string postBodyInput, DateTime postDateCreated*/)
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
