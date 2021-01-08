using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPerfect.Models.Database
{
    [Table("send_emails")]
    public class SendEmail : BaseEntity
    {
        [Column("description")]
        public string Description { get; set; }

        [Column("attach")]
        public string Attach { get; set; }

        [Column("send_for_email")]
        public string SendForEmail { get; set; }
    }
}
