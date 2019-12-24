using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakturiFirst.Models
{
    public class Faktura
    {
        public int Faktura_ID { get; set; }
        public int Firm_ID { get; set; }
        public int Client_ID { get; set; }
        public bool Faktura_Status { get; set; }
        public IEnumerable<Article> Faktura_Artikli { get; set; }
        public float Faktura_Suma { get; set; }
        public DateTime Faktura_DatumIzdavanje { get; set; }
        public DateTime Faktura_DatumDospevanje { get; set; }
        public float Faktura_TotalDDV { get; set; }
        public string Faktura_Zabeleska { get; set; }
    }
}