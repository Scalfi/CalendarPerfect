using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPerfect.Models.Database
{
    [Table("calendars")]
    public class Calendar : BaseEntity
    {
        [ForeignKey(nameof(User))]
        [Column("user_id")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Customer))]
        [Column("customer_id")]
        public int CustomerId{ get; set; }
        public Customer Customer { get; set; }

        [Column("date_consult")]
        public DateTime DateConsult { get; set; }

        [NotMapped]
        public new string Name { get; set; }
    }
}
