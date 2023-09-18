using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDLC_ForeignKeys
{
    public class PostViewModel
    {
        public int PostId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorField { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }

    }
}
