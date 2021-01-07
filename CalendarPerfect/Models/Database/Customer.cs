using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPerfect.Models.Database
{
    public class Customer : BaseEntity
    {
        [Column("age")]
        public int Age { get; set; }

        [Column("consultation_value")]

        public double ConsultationValue { get; set; }

        [Column("description")]
        public string Description { get; set; }


    }
}
