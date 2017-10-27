using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReview.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Display(Name ="Title")]
        public string ReviewTitle { get; set; }
        [Display(Name ="Review")]
        public string ReviewContent { get; set; }
        public string Username { get; set; }
        public int Stars { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}