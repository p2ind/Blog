using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class Category : BaseEntity
    {
        [StringLength(75)]
        public string Title { get; set; }

        [StringLength(100)]
        public string MetaTitle { get; set; }

        [StringLength(100)]
        public string Slug { get; set; }
        public string Content { get; set; }
    }
}
