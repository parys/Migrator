using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models
{
    public partial class RoleClaim
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual Role Role { get; set; }
    }
}
