using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Suanha3.Models
{
    public class AdminUser
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; internal set; }
        public string Services { get; internal set; }
        public DateTime? SubmittedDate { get; internal set; }

    }
}