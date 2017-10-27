﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReview.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Display(Name ="Location")]
        public string CategoryTitle { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        
    }
}