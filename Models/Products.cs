using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakturiFirst.Models
{
    public class Products
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public float Product_Price { get; set; }
        public int Product_DDV_Percent { get; set; }
        public float Product_Price_with_DDV { get; set; }
        public int Firm_ID { get; set; }
    }
}