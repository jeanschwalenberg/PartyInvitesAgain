using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvitesAgain.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your e-mail address.")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid e-mail address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll be attending.")]
        public bool? WillAttend { get; set; }
    }
}