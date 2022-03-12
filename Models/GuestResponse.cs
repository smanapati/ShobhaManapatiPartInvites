using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShobhaManapatiPartInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your Email address")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
