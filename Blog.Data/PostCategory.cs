using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class PostCategory
    {
        public string PostId { get; set; }
        public Post Post { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
