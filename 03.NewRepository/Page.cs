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
                PageDateCreated =DateTime.Now
                },
                new PrivatePage()
                {
                PageName = "Sample Private Page",
                ViewablePage = false,
                PageDateCreated=DateTime.Now
                }
            };
        }
        public List<BasePage> GetPageList()
        {
            return this.pageList;
        }

        public void RepoAddPage(BasePage page)
        {
            this.pageList.Add(page);
        }
        public void DeletePage(string deleteName)
        {
            this.pageList.RemoveAll(s => s.PageName == deleteName);
        }
    }
}
