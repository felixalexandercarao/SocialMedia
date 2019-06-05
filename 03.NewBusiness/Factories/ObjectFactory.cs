using System;
using NewEntity;

namespace _03.NewBusiness
{
    abstract class ObjectFactory
    {
        public abstract BasePost createPost(string postBodyInput,DateTime postDateCreated);
        public abstract BasePage createPage(string pageNameInput, DateTime pageDateCreated);
    }
}
