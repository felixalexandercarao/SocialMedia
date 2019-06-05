using NewEntity;
using System;
using System.Collections.Generic;

namespace _03.NewRepository
{
    public class PageList
    {

        public List<BasePage> pageList { get; set; }
        public PageList()
        {
            this.pageList = new List<BasePage>()
            {
                new PublicPage()
                {
                PageName = "Sample Public Page",
                ViewablePage = true,
                PageDateCreated =DateTime.Now,
                NumberofFollowers = 0
                },
                new PrivatePage()
                {
                PageName = "Sample Private Page",
                ViewablePage = false,
                PageDateCreated=DateTime.Now,
                SecretPageInfo="This is a sample secret page"

                }
            };
        }
        public List<BasePage> GetPageList()
        {
            return this.pageList;
        }

        public void RepoAddPage(BasePage p)
        {
            this.pageList.Add(p);
        }
        public void DeletePage(string deleteName)
        {
            this.pageList.RemoveAll(s => s.PageName == deleteName);
        }
    }
}
