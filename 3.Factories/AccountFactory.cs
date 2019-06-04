using System;
using Entity;

namespace _3.Factories
{
    abstract class AccountFactory
    {
        public abstract FanAccount createFanAccount();
        public abstract PersonalAccount createPersonalAccount();
    }
}
