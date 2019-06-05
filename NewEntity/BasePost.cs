using System;

namespace NewEntity
{
    public class BasePost
    {
        public string Body { get; set; }
        public bool ViewablePost { get; set; }
        public DateTime PostDateCreated { get; set; }
    }
}
