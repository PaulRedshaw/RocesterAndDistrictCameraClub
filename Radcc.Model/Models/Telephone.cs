using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Radcc.Model.Models
{
    public class Telephone
    {   [Key]
        public int TelephoneId { get; set; }
        [ForeignKey("Id")]
        public Member Member { get; set; }
                
        public string MemberId { get; set; }
        public TelephoneType Type{ get; set; }
    }
    public enum TelephoneType
    {
        Home,
        Mobile,
        Work
       
    }
}