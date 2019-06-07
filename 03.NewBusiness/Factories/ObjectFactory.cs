using System;
using NewEntity;

namespace _03.NewBusiness
{
    interface  IObjectFactory
    {
        BasePost createPost();
        BasePage createPage();
    }
}
