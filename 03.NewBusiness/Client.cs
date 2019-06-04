using System;
using System.Collections.Generic;
using System.Text;
using NewEntity;

namespace _03.NewBusiness
{
    class Client
    {
        private readonly BasePost _post;
        private readonly BasePage _page;
        public Client(ObjectFactory OF)
        {
            _page = OF.createPage();
            _post = OF.createPost();
        }
        public string Res()
        {
            return $"post: {_post.GetType().Name} and Page {_page.GetType().Name}";
        }

    }
}
