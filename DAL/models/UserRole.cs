using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models
{
    public partial class UserRole// : IdentityUserRole<string>
    {
        [Key]
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
