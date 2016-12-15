using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furst_Alpha_1.Models
{
    public class Makes
    {
        [Key]
        public int Make_Id { get; set; }
        public string Make { get; set; }
    }
}