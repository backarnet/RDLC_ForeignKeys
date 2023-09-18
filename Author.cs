using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDLC_ForeignKeys
{
    internal class Author
    {
        public Author(int id, string fullName, string field)
        {
            Id = id;
            FullName = fullName;
            Field = field;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Field { get; set; }
    }
}
