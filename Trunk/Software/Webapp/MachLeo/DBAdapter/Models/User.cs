using System;
using System.Collections.Generic;

namespace DBAdapter.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Issue> Issue { get; set; }

    }
}
