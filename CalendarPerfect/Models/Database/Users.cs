using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPerfect.Models.Database
{
    public class Users : BaseEntity
    {
        [Column("login")]
        [Required(ErrorMessage = "The login is required")]
        public string Login { get; set; }

        [Column("email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Column("password")]
        [Required(ErrorMessage = "The password is required")]

        public string Password { get; set; }
    }
}
