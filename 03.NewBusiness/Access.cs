using System;
using System.Collections.Generic;
using System.Text;

namespace _03.NewBusiness
{
    public class Access
    {
        public void ayy()
        {
            Client c = new Client(new PrivateObjectFactory());
            Console.WriteLine(c.Res());
        }
    }
}