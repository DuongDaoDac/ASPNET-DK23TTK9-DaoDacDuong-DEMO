using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Suanha3.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublishedDate { get; set; }
        public string Category { get; internal set; }
        public string CreatedDate { get; internal set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string pageSize { get; set; }
        public DateTime? SubmittedDate { get; internal set; }
        

    }
}