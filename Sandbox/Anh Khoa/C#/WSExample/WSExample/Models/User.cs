using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WSExample.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Guid ClassID { get; set; }
        public virtual Class Class { get; set; }
    }
}