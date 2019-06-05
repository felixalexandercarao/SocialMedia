using System;
using System.Collections.Generic;
using System.Text;
using _03.NewRepository;
using NewEntity;

namespace _03.NewBusiness
{
    class AddObject
    {
        PageList PL = new PageList();
        public void AddPage(ObjectFactory OF, string pageName)
        {
            PL.RepoAddPage(OF.createPage(pageName, DateTime.Now));
            foreach (BasePage pg in PL.GetPageList())
            {
                Console.WriteLine("Name: {0} | Public: {1}", pg.PageName, pg.ViewablePage);
            }
        }
        public void AddPost(ObjectFactory OF, string postName)
        {
            PL.RepoAddPage(OF.createPage(pageName, DateTime.Now));
            foreach (BasePage pg in PL.GetPageList())
            {
                Console.WriteLine("Name: {0} | Public: {1}", pg.PageName, pg.ViewablePage);
            }
        }
    }
}
