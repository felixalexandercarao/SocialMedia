using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Post:BaseClass
    {
        public string PostType { get; set; }
        public string PostBody { get; set; }
        public string Author { get; set; }
    }
}
