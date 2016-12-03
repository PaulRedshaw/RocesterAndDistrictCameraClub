using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Radcc.Model.Models
{
    public class Interest
    { 
        [Key]
        public int InterestId { get; set; }
        public string Id { get; set; }

        [ForeignKey("Id")]
        public virtual Member Member { get; set; }
    }
}