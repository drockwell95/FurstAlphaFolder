using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furst_Alpha_1.Models
{
    public class Types
    {
        [Key]
        public int Type_Id { get; set; }
        public string Type { get; set; }
    }
}