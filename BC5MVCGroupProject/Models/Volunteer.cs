using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BC5MVCGroupProject.Models
{
    public class Volunteer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        public int Phone { get; set; }
        public string Email { get; set; }
        [DisplayName("Questions or Comments")]
        public string Description { get; set; }
    }
}