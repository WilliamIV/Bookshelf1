using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf1.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Publish Date")]
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

       [ForeignKey("Category")]
       //[Display (Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}