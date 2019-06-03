using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class PostList
    {
        public List<Post> postList { get; set; }
        public PostList()
        {
            this.postList = new List<Post>()
            {
                new Post()
                {
                    Author="Lex Carao",
                    PostBody="You cheated the not only the game, but also yourself",
                    PostType="Text",
                    ID="P-001",
                    Privacy="Public",
                    DateCreated=DateTime.Today
                },
                new Post()
                {
                    Author="Beliebers",
                    PostBody="Album out",
                    PostType="Text",
                    ID="P-002",
                    Privacy="Public",
                    DateCreated=DateTime.Today
                },
                new Post()
                {
                    Author="Lakers Fan Page",
                    PostBody="Bring Back Kobe",
                    PostType="Text",
                    ID="P-003",
                    Privacy="Public",
                    DateCreated=DateTime.Today
                }
            };
        }
    }
}
