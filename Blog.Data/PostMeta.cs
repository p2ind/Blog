﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class PostMeta : BaseEntity
    {
        public string PostId { get; set; }

        [StringLength(50)]
        public string Key { get; set; }
        public string Content { get; set; }
    }
}
