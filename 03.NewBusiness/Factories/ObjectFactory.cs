using System;
using NewEntity;

namespace _03.NewBusiness
{
    abstract class ObjectFactory
    {
        public abstract BasePost createPost();
        public abstract BasePage createPage();
    }
}
