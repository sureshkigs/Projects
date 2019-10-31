using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EMCORWebApplication.Models
{
    [Table("User")]
    public class UserClass
    {
        [Key]
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}