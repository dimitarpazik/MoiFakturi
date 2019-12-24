using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace FakturiFirst.Models
{
    public class Clients
    {
        public int Client_ID { get; set; }
        public string Client_Name { get; set; }
        public string Client_Email { get; set; }
        public string Client_TFN { get; set; }
        public string Client_Address { get; set; }
        public string Client_City { get; set; }
        public string Client_State { get; set; }
        public string Client_CityPostCode { get; set; }
        public string Client_Signature { get; set; }
    }
}