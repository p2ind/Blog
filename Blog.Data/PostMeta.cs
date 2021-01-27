using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class PostMeta
    {
        [Key]
        public Guid PostMetaId { get; set; }

        public string PostId { get; set; }
        public Post Post { get; set; }

        [StringLength(50)]
        public string Key { get; set; }
        public string Content { get; set; }
    }
}
