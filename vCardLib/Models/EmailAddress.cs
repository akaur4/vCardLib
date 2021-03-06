﻿using System.Net.Mail;

namespace vCardLib.Models
{
    /// <summary>
    /// Class to hold email addresses
    /// </summary>
    public class EmailAddress
    {
        /// <summary>
        /// The email address
        /// </summary>
        public MailAddress Email { get; set; }
        /// <summary>
        /// The email address type
        /// </summary>
        public EmailType Type { get; set; }
    }

    /// <summary>
    /// Various email address types in a vCard
    /// </summary>
    public enum EmailType
    {
        Work,
        Internet,
        Home,
        AOL,
        Applelink,
        IBMMail,
        None
    }
}
