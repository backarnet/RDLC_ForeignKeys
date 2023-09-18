using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDLC_ForeignKeys
{
    internal class Post
    {
        public Post(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Author_Id { get; set; }
    }
}
