using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(15)]
        public string MobileNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(32)]
        public string Password { get; set; }
        public DateTime  RegisteredAt { get; set; }
        public DateTime LastLogin { get; set; }
        public string Intro { get; set; }
        public string Profile { get; set; }
        public string ProfileImage { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
