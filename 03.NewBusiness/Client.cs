using System;
using System.Collections.Generic;
using System.Text;
using NewEntity;

namespace _03.NewBusiness
{
    class Client
    {
        private readonly BasePage _page;
        public Client(ObjectFactory OF,string pageName)
        {
            _page = OF.createPage(pageName,DateTime.Now);
        }
        public string Res()
        {
            return $"Page: {_page.PageName}, DateCreated: {_page.PageDateCreated}, Viewable: {_page.ViewablePage}";
        }

    }
    //class newPage
    //{

    //}
}
