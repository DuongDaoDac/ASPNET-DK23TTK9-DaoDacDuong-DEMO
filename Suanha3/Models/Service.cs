using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.UI.WebControls;

namespace Suanha3.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; internal set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceImageUrl { get; set; }
        public string ServiceCategory { get; set; }
        public string ServiceAddress { get; set; }
        public string ServicePhone { get; set; }
        public string ServiceEmail { get; set; }
        public string type { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
       
        

    }
}