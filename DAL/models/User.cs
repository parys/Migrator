﻿using System;
using System.Collections.Generic;
using System.Security.Policy;
using DAL.models;

namespace DAL
{
    public class User
    {
        public int Id { get; set; }

        public int OldId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string PhotoPath { get; set; }

        public string FullName { get; set; }

        public bool Gender { get; set; }

        public string Email { get; set; }

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

        public List<ForumMessage> ForumMessages { get; set; }

        public List<Comment> Comments { get; set; }

    }
}
