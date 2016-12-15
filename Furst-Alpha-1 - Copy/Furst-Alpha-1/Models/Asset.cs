using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Furst_Alpha_1.Models
{
    public class Asset
    {
        [Key]
        public int Asset_Id { get; set; }
        [ForeignKey("Vendor_Id")]
        public int Vendor_Id { get; set; }
        [ForeignKey("Category_Id")]
        public int Category_Id { get; set; }
        [ForeignKey("Type_Id")]
        public int Type_Id { get; set; }
        [ForeignKey("Make_Id")]
        public int Make_Id { get; set; }
        [ForeignKey("Model_Id")]
        public int Model_Id { get; set; }

       // public string Vendor { get; set; }
       // public string Category { get; set; }
       // public string Type { get; set; }
        public string Image { get; set; }
        //public string Make { get; set; }
       // public string Model { get; set; }
        public int Year_Purchased { get; set; }
        public double Rental_Price { get; set; }
        public int Num_Techs_Req { get; set; }
        public bool Availability { get; set; }    
      
    }
}