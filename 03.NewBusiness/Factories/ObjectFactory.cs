using System;
using NewEntity;

namespace _03.NewBusiness
{
    interface  IObjectFactory
    {
        BasePost createPost(/*string postBodyInput,DateTime postDateCreated*/);
        BasePage createPage(/*string pageNameInput, DateTime pageDateCreated*/);
    }
}
