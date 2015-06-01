using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class User
    {
        public User()
        {
            this.UserClaims = new HashSet<UserClaim>();
            this.UserLogins = new HashSet<UserLogin>();
            this.Roles = new HashSet<Role>();
            this.ForumMessages = new HashSet<ForumMessage>();
            this.BlogComments = new HashSet<BlogComment>();
            this.NewsComments = new HashSet<NewsComment>();

        }

        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<UserClaim> UserClaims { get; set; }
        public virtual ICollection<UserLogin> UserLogins { get; set; }
        public virtual ICollection<Role> Roles { get; set; }



       // public int Id { get; set; }

        public int OldId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string PhotoPath { get; set; }

        public string FullName { get; set; }

        public bool Gender { get; set; }

       // public string Email { get; set; }

        public string Homepage { get; set; }

        public string Skype { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public long RegistrationDateUTC { get; set; }

        public string Ip { get; set; }

        public DateTime? Birthday { get; set; }

        public bool Verify { get; set; }

        public long LastModifiedUTC { get; set; }

        public string Title { get; set; }

        public virtual ICollection<ForumMessage> ForumMessages { get; set; }

        public virtual ICollection<BlogComment> BlogComments { get; set; }

        public virtual ICollection<NewsComment> NewsComments { get; set; }

    }
}
