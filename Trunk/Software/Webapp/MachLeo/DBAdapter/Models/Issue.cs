using System;
using System.Collections.Generic;

namespace DBAdapter.Models
{
    public partial class Issue
    {
        public Guid Id { get; set; }
        public string Decription { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }

        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
    }
}
