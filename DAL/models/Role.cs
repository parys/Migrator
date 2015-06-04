using System.Collections.Generic;

namespace DAL.models
{
    public partial class Role //: IdentityRole<string>
    {

        public Role()
        {
            this.Users = new HashSet<User>();
            this.Claims = new HashSet<RoleClaim>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string NormalizedName { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<RoleClaim> Claims { get; set; }
    }
}
