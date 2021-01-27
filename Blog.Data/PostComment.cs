using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class PostComment 
    {
        [Key]
        public Guid PostCommentId { get; set; }

        public string PostId { get; set; }
        public Post Post { get; set; }

        [StringLength(100)]
        public string Title { get; set; }
        public Boolean Published { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }
    }
}
