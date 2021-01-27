using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class Post
    {
        [Key]
        public Guid PostId { get; set; }

        public string AuthorId { get; set; }
        public User User { get; set; }

        [StringLength(75)]
        public string Title { get; set; }

        [StringLength(100)]
        public string MetaTitle { get; set; }

        [StringLength(100)]
        public string Slug { get; set; }
        public string Summary { get; set; }
        public Boolean Published { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }

        public ICollection<PostComment> PostComment { get; set; }
        public ICollection<PostMeta> PostMeta { get; set; }
    }
}
