using System;
using NewEntity;

namespace _03.NewBusiness
{
    class PrivateObjectFactory : ObjectFactory
    {
        public override BasePage createPage(string pageNameInput, DateTime pageDateCreated)
        {
            return new PrivatePage()
            {
                PageName = pageNameInput,
                ViewablePage = false,
                PageDateCreated=pageDateCreated,
                SecretPageInfo="This is a secret page"
                
            };
        }

        public override BasePost createPost(string postBodyInput, DateTime postDateCreated)
        {
            return new PrivatePost()
            {
                Body=postBodyInput,
                PostDateCreated=postDateCreated,
                ViewablePost=false,
                SecretPostInfo="This is a secret post"
            };
        }
    }
}
