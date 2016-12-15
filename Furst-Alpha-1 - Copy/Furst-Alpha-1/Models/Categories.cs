using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furst_Alpha_1.Models
{

    public class Categories
    {
        [Key]
        public int Category_Id { get; set; }
        public string Category { get; set; }
    }
}