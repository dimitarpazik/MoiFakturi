//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FakturiFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Fakturas = new HashSet<Faktura>();
        }
    
        public int Client_ID { get; set; }
        public string Client_Name { get; set; }
        public string Client_Email { get; set; }
        public string Client_TFN { get; set; }
        public byte[] Client_Signature { get; set; }
        public string Client_Address { get; set; }
        public string Client_City { get; set; }
        public string Client_State { get; set; }
        public string Client_CityPostCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faktura> Fakturas { get; set; }
    }
}
