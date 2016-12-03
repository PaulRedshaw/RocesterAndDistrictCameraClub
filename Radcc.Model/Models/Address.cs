using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Radcc.Model.Models
{
    public class Address
    {

        [Key, ForeignKey("Id")]
        public string Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Town { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string PostCode { get; set; }
        
        ICollection<Telephone> TelephoneNumbers { get; set; }
       
    }
}