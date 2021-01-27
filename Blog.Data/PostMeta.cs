using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    [Table("PostMeta")]
    public class PostMeta
    {
        [Key]
        public Guid PostMetaId { get; set; }

        [ForeignKey("Post")]
        public string PostId { get; set; }
        public Post Post { get; set; }

        [StringLength(50)]
        public string Key { get; set; }
        public string Content { get; set; }
    }
}
