using System;
using NewEntity;

namespace _03.NewBusiness
{
    class PrivateObjectFactory : ObjectFactory
    {
        public override BasePage createPage()
        {
            return new PrivatePage()
            {
                PageName ="ayyy"
            };
        }

        public override BasePost createPost()
        {
            return new PrivatePost();
        }
    }
}
