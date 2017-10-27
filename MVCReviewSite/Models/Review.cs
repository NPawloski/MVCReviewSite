using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Reviewer { get; set; }
        public string Content { get; set; }
        [Display(Name = "Date")]
        public DateTime PublishedDate { get; set; }

        [ForeignKey("Category")]
        public int Cetagory { get; set; }
        public virtual Category Category { get; set; }



    }
}