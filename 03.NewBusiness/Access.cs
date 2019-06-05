using _03.NewRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.NewBusiness
{
    public class Access
    {
        PageList c = new PageList();
        AddObject AO = new AddObject();
        public void AccessPageCreate(string s)
        {
            if (s == "Public Page")
            {
                AO.AddPage(new PublicObjectFactory(), "New Public Page");
            }
            if (s == "Private Page")
            {
                AO.AddPage(new PrivateObjectFactory(), "New Private Page");
            }
            if (s == "Private Post")
            {
                AO.AddPage(new PrivateObjectFactory(), "New Private Post");
            }
            if (s == "Public Post")
            {
                AO.AddPage(new PublicObjectFactory(), "New Public Post");
            }




        }
    }
}