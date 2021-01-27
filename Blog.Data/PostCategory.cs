using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    [Table("PostCategory")]
    public class PostCategory
    {
        [ForeignKey("Post")]
        public string PostId { get; set; }
        public Post Post { get; set; }

        [ForeignKey("Category")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
