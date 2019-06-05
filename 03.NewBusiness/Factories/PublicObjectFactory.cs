using NewEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.NewBusiness
{
    class PublicObjectFactory : ObjectFactory
    {
        public override BasePage createPage(string pageNameInput, DateTime pageDateCreated)
        {
            return new PublicPage()
            {
                PageName = pageNameInput,
                ViewablePage = true,
                PageDateCreated = pageDateCreated,
                NumberofFollowers = 0
            };
        }

        public override BasePost createPost(string postBodyInput, DateTime postDateCreated)
        {
            return new PublicPost()
            {
                Body = postBodyInput,
                PostDateCreated = postDateCreated,
                ViewablePost = true,
                NumberOfLikes=1
            };
        }
    }
}
