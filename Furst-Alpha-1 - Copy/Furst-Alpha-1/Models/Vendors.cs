using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furst_Alpha_1.Models
{
    public class Vendors
    {
        [Key]
        public int Vendor_Id { get; set; }
        public string Vendor { get; set; }
    }
}