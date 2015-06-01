using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models
{
    public partial class UserLogin
    {
        [Key]
        public string ProviderKey { get; set; }

        public string LoginProvider { get; set; }
        
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
