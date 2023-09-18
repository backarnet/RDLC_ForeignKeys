using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDLC_ForeignKeys
{
    public partial class FormMain : Form
    {
        List<Author> Authors;
        List<Post> Posts;
        public static List<PostViewModel> FullPosts;

        public FormMain()
        {
            InitializeComponent();
            Authors = new List<Author>
            {
                new Author(1, "Ahmad", "Math"),
                new Author(2, "Sami", "C++"),
                new Author(3, "Ali", "Algorithms"),
                new Author(4, "Lamees", "Arabic"),
                new Author(5, "Douha", "Languages"),
            };
            Posts = new List<Post>
            {
                new Post(1, "Article 001")
                {
                    Author_Id = 1,
                    Content = "First article body",
                },
                new Post(2, "Article 234")
                {
                    Author_Id = 1,
                    Content = "Second article body",
                },
                new Post(3, "Article 545")
                {
                    Author_Id = 2,
                    Content = "Third article body",
                },
                new Post(4, "Article tyy")
                {
                    Author_Id = 4,
                    Content = "Fourth article body",
                },
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitViewModel();
            new FormReportViewer().ShowDialog();
        }

        private void InitViewModel()
        {
            // don't worry.. this like a SELECT and JOIN statement

            FullPosts = Authors.Join(Posts, a => a.Id, p => p.Author_Id,
                (a, p) => new PostViewModel
                {
                    PostId = p.Id,
                    AuthorName = a.FullName,
                    AuthorField = a.Field,
                    PostContent = p.Content,
                    PostTitle = p.Title,
                }).ToList();
        }
    }
}
