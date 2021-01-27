using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [StringLength(75)]
        public string Title { get; set; }

        [StringLength(100)]
        public string MetaTitle { get; set; }

        [StringLength(100)]
        public string Slug { get; set; }
        public string Content { get; set; }
    }
}
