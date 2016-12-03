using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radcc.Model.Models
{
    public class Member: IUser
    {
        [MaxLength(128), ForeignKey("ApplicationUser")]
        public virtual string Id
        {
            get
            {
                return Id;
            }
        }

       
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string UserName
        {
            get
            {
                return UserName;
            }

            set
            {
                UserName = value;
            }
        }

        [Column(TypeName = "image")]
        public byte[] ProfileImage { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Interest> Interests { get; set; }
        public virtual ICollection<Bio> Biography { get; set; }

      
    }
}
