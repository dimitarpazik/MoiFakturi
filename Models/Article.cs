using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakturiFirst.Models
{
    public class Article
    {
        public int ID { get; set; }
        public int Product_ID { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float DDVPrice { get; set; }
    }
}