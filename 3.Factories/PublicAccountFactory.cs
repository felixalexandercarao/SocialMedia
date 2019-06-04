using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace _3.Factories
{
    class PublicAccountFactory : AccountFactory
    {
        public override FanAccount createFanAccount()
        {
            throw new NotImplementedException();
        }

        public override PersonalAccount createPersonalAccount()
        {
            throw new NotImplementedException();
        }
    }
}
