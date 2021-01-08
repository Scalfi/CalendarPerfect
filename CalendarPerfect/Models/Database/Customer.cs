using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPerfect.Models.Database
{
    [Table("customers")]
    public class Customer : BaseEntity
    {
        [Column("age")]
        public int Age { get; set; }

        [Column("consultation_value")]

        public double ConsultationValue { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [ForeignKey(nameof(User))]
        [Column("user_id")]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
