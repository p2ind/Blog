using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    [Table("PostTag")]
    public class PostTag
    {
        [ForeignKey("Post")]
        public string PostId { get; set; }
        public Post Post { get; set; }

        [ForeignKey("Tag")]
        public string TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
