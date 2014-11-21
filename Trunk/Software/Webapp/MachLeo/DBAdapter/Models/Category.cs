using System;
using System.Collections.Generic;

namespace DBAdapter.Models
{
    public partial class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Issue> Issue { get; set; }
    }
}
