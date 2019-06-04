using System;
using System.Collections.Generic;
using System.Text;

namespace _03.NewBusiness
{
    class PublicObjectFactory : ObjectFactory
    {
        public override BasePage createPage()
        {
            return new PublicPage();
        }

        public override BasePost createPost()
        {
            return new PublicPost();
        }
    }
}
