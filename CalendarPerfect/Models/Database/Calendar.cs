using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPerfect.Models.Database
{
    public class Calendar
    {

        public int UserId { get; set; }
        public User User { get; set; }

        public int CustomerId{ get; set; }
        public Customer Customer { get; set; }

        public DateTime Date { get; set; }
    }
}
