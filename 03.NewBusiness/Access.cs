using _03.NewRepository;
using NewEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.NewBusiness
{
    public class Access
    {
        AddObject AO = new AddObject();
        public void AccessPageAndPostCreate(string privacy)
        {
            AO.AddPageAndPost(privacy);
        }

    }
}