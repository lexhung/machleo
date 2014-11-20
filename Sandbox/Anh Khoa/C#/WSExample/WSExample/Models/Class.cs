using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WSExample.Models
{
    [Table("Class")]
    public class Class
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<User> Users { get; set; }
    }
}