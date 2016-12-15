using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furst_Alpha_1.Models
{
    public class Models
    {
        [Key]
        public int Model_Id { get; set; }
        public string Model { get; set; }
    }
}