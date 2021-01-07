using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPerfect.Models.Database
{
    public class CustomerSickness : BaseEntity
    {
        [ForeignKey(nameof(Sickness))]
        [Column("sickness_id")]
        public int SicknessId { get; set; }

        public HashSet<Sickness> Sicknesses { get; set; }

        [ForeignKey(nameof(Customer))]
        [Column("customer_id")]
        public int CustomerId { get; set; }
        public List<Customer> Customeres { get; set; }
    }
}
